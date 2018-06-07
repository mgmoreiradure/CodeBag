if __name__ == '__main__':
    n = int(input())
    student_marks = {}
    for _ in range(n):
        name, *line = input().split()
        scores = list(map(float, line))
        student_marks[name] = scores
    query_name = input()
    
    count= 0
    lenght = len(student_marks[query_name])
    for i in range(lenght):
        count+= student_marks[query_name][i]
    print("{0:.2f}".format(count / lenght))
