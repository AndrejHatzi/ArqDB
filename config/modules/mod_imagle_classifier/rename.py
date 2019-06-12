import os
imdir = 'images'
#para criar pastas
if not os.path.isdir(imdir):
    os.mkdir(imdir)

#apenas aqueles que tem 'fidget'
folders = [folder for folder in os.listdir('.') if 'CC_' in folder]
print(folders) #==> vai imprimir todas as pastas com esse nome!

n = 0
for folder in folders:
    #image file, eh um loop for cada item dentro da pasta
    for imfile in os.scandir(folder):
        os.rename(imfile.path, os.path.join(imdir, '{:06}.png'.format(n)))
        n += 1
