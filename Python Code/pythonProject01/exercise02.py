'''
这是多行注释
'''


# for i in range(10):
#     print(i)


# for i in range(5,15):
#     if i>5:
#         break
#     print(i)


s = input()
a = s.split(' ')
d= {}
for i in a:
    key = i
    value = a.count(i)
    d[key] = value

for i in d.keys():
    print(i,d[i])
