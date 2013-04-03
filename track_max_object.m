%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%% final code for tracking of max object from live video      %%
%% my code for tracking object 4m live video                  %%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

clear all;
vid = videoinput('winvideo');%,1,'YUY2_640x480');
 set(vid,'ReturnedColorSpace','rgb');
 set(vid,'TriggerRepeat',Inf);
 vid.FrameGrabInterval = 2;
 start(vid);

while(vid.FramesAcquired<=10) % Stop after 1000 frames 
data = getdata(vid,5);
diff_im = imabsdiff(data(:,:,:,1),data(:,:,:,5)); %background subtraction
diff = rgb2gray(diff_im);
diff_edge=edge(diff,'canny');%,0.3);
diff_bw = im2bw(diff,0.1);%0.2); %converting to black & white
se=ones(8,8);
dilated=imdilate(diff_edge,se);
filled=imfill(dilated,'holes');
labelled=bwlabel(filled);
mx=max(max(labelled));%total no of distinct regions obtained
%area_struct = regionprops(labelled,'Area');
%area=cat(1,area_struct.Area);
%max_area=max(area); %get region of max area
%for k=1:mx
%    if(area(k) == max_area)
%        index=k; %get index of max area region
%    end
%end

desired_object=labelled;
[row,col,plane]=size(labelled); %size of labeled a row x col x plane

index=mx;
centroid_array=zeros(index,2);

for i=1:index
    desired_object=labelled;

for k=1:row %remove all unwanted regions from image
    for j=1:col
        if(labelled(k,j)==index)
            desired_object(k,j)=1;
        else
             desired_object(k,j)=0;
        end
    end
end

centroid  = regionprops(desired_object, 'centroid'); %find centroid of extracted object
x=centroid.Centroid(1); %centroid co-ordinates
y=centroid.Centroid(2); %centroid co-ordinates

centroid_array(index,1)=x;
centroid_array(index,2)=y;
end

imshow(data(:,:,:,3)); title('tracked object');
hold(imgca,'on');

for i=1:index
    x=centroid_array(index,1);
    y=centroid_array(index,2);

plot(imgca,x,y,'b*'); %imgca= handle for current image
text(x,y,'string') ;
hold on;
x1=x/2; y1=y/2;
x1=(x-x1)/2; y1=(y-y1)/2;
dist=sqrt( ( (x-x1)^2 + (y-y1)^2 ) /2 );
dist=dist*2;
rectangle('Position',[(x/2) (y/2) dist dist],'LineWidth',2,'EdgeColor','r','LineStyle','-.');

end

hold(imgca,'off');

end
stop(vid);
