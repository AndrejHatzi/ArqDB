#["a", b, c, 1.56, 89]
def get_arguments(argument_layer:str) -> list:
    args : list = [];
    argument_layer = argument_layer[1:-1].replace(' ','').split(',');
    args = argument_layer;
    return args
