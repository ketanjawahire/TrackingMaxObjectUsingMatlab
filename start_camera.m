function start_camera()
 vid = videoinput('winvideo');%,1,'YUY2_640x480');
 set(vid,'ReturnedColorSpace','rgb');
 set(vid,'TriggerRepeat',Inf);
 vid.FrameGrabInterval = 2;
 start(vid);
 save('c:\cam_conn.mat','vid');
 preview(vid);
 