def arrays(arr):
    # complete this function
    # use numpy.array 
    arr.reverse()
    np_array =numpy.array( list(map(float, arr)))
       
    return np_array
