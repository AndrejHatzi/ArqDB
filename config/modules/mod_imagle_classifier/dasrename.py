import os
a = 0
for filename in os.listdir('clean_Dataset_Copy'):
    os.rename(('clean_Dataset_Copy/{}').format(filename), ('a{}.png').format(a))
    a+=1
    
