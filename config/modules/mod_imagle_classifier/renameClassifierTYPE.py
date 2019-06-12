import os, shutil
_xmls : list = os.listdir('annotations')

i : int
for i in range(len(_xmls)):
    path : str = ('annotations/{}').format(_xmls[i])
    path_exp : str = ('annotations/{}.hxml').format(_xmls[i])
    with open(path, 'r', encoding='utf-8') as f:
        line : str
        for line in f:
            with open(path_exp, 'a', encoding='utf-8') as f:
                if '<name>Ponta_Seta</name>' in line:
                    f.write('    <name>Ametista</name>\n')
                else:
                    f.write(line)
    nome : str = _xmls[i]
    nome_temp : str = ('{}.hxml').format(nome)
    os.remove(('annotations/{}').format(_xmls[i]))
    path_remove : str = ('annotations/{}').format(nome_temp)
    os.rename(path_remove, nome)
    shutil.move(nome, 'annotations')
