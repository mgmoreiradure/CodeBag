if __name__ == '__main__':
    N = int(input())    
    l = []
    for i in range(0,N):
        s = input().split()
        
        if s[0]!= "print" :
            if s[0]== "insert":
                l.insert(int(s[1]),int(s[2]))
            if s[0] =="remove":
                l.remove(int(s[1]))
            if s[0]=="append": 
                l.append(int(s[1]))
            if s[0]=="sort":
                l.sort()
            if s[0]=="pop": 
                l.pop()
            if s[0]=="reverse":
                l.reverse()
        else:
            print(l)
