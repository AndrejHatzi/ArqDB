import pandas as pd
import folium
#https://getbootstrap.com/docs/3.3/components/
data : list;
with open('current_loc.lc', 'r', encoding='utf-8') as f:
    data = f.read().replace('\ufeff','').replace('\n','').split(',');

#print(data);
#[0] = lat
#[1] = lon
#[2] = colour
#[3] = label

if data[2] == "Roxo":
    data[2] = "purple";

#print(data);
mapa = folium.Map(
    location = [data[0], data[1]],
    zoom_start = 4,
    );

folium.Marker(
    location = [data[0], data[1]],
    icon=folium.Icon(color=str(data[2])),
    popup=str(data[3])
    ).add_to(mapa);

folium.Marker(
    #45.042833162 1.172332644
    location = [45.042833162, 1.172332644],
    icon=folium.Icon(color='orange', icon='glyphicon-fire'),
    popup="Lascaux"
    ).add_to(mapa);

folium.Marker(
    #45.042833162 1.172332644
    location = [38.0150600, -7.8632300],
    icon=folium.Icon(color='red', icon='glyphicon-tree-deciduous'),
    popup="Beja"
    ).add_to(mapa);


mapa.save("current_location.html")

'''
brasil = folium.Map(
    location=[-16.1237611, -59.9219642],    # Coordenadas retiradas do Google Maps
    zoom_start=4
)

folium.Marker(
    location=[39.462094, -8.387384],
    icon=folium.Icon(color="lightred"),
    popup='Almoroul',
).add_to(brasil)

brasil.save('index.html')
#lightgreen', 'darkred', 'white', 'purple', 'orange',
#'blue', 'lightgrayblack', 'lightblue', 'gray', 'red', 'green',
#'darkpurple', 'darkgreen', 'cadetblue', 'darkblue', 'pink', 'beige',
#'lightred
'''
