if __name__ == '__main__':
    names = []
    scores=[]
    seconds=[]
    for _ in range(int(input())):
        name = input()
        score = float(input())
        names.append(name)
        scores.append(score)
        
    mini= min(scores)
    
    while min(scores) == mini:
        index=scores.index(mini)
        del scores[index]
        del names[index]
    
    mini= min(scores)
    for i in range(len(scores)):
        if scores[i]== mini:
            seconds.append(names[i])
    
    seconds.sort();
    for i in range(len(seconds)):
        print(seconds[i])
    
