import cv2
with open('image.nm', 'r', encoding='utf-8') as f:
    c = f.readlines()

name : str = c[0].replace('\uffeff','').replace('\n','')
path : str = c[1].replace('\\','\\').replace('\n','')
print(name, path)

if cv2.waitKey(33) == ord('a'):
   print "pressed a"
   
im_gray = cv2.imread(path, cv2.IMREAD_GRAYSCALE)
#im_hsv = cv2.applyColorMap(im_gray, cv2.COLORMAP_HSV)
im_spring = cv2.applyColorMap(im_gray, cv2.COLORMAP_JET)
cv2.imshow(name[1:],im_spring)

name = name[1:] + ".png";
cv2.imwrite(name,im_spring)

