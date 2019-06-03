import cv2

im_gray = cv2.imread("mapa2.PNG", cv2.IMREAD_GRAYSCALE)
im_color = cv2.applyColorMap(im_gray, cv2.COLORMAP_JET)
im_au = cv2.applyColorMap(im_gray, cv2.COLORMAP_AUTUMN)
im_bone = cv2.applyColorMap(im_gray, cv2.COLORMAP_BONE)
im_winter = cv2.applyColorMap(im_gray, cv2.COLORMAP_WINTER)
im_rainbow = cv2.applyColorMap(im_gray, cv2.COLORMAP_RAINBOW)
im_ocean = cv2.applyColorMap(im_gray, cv2.COLORMAP_OCEAN)
im_summer = cv2.applyColorMap(im_gray, cv2.COLORMAP_SUMMER)
im_spring = cv2.applyColorMap(im_gray, cv2.COLORMAP_JET)
im_cool = cv2.applyColorMap(im_gray, cv2.COLORMAP_SPRING)
im_hsv = cv2.applyColorMap(im_gray, cv2.COLORMAP_HSV)
im_pink = cv2.applyColorMap(im_gray, cv2.COLORMAP_PINK)
im_hot = cv2.applyColorMap(im_gray, cv2.COLORMAP_HOT)


cv2.imshow('source.png',im_color)
cv2.imshow('source1.png',im_au)
cv2.imshow('source2.png',im_bone)
cv2.imshow('source3.png',im_winter)
cv2.imshow('source4.png',im_rainbow)#---
cv2.imshow('source5.png',im_ocean)
cv2.imshow('source6.png',im_summer)
cv2.imshow('HeighMap - Desenvolvimento.png',im_spring) #---
cv2.imshow('source8.png',im_cool)
cv2.imshow('source9.png',im_hsv)#---
cv2.imshow('source10.png',im_pink)
cv2.imshow('source11.png',im_hot)
