# a = int(input())
# if a > 10:
#     print("1小于10")
# elif a == 10:
#     print("1等于10 ")
# else:
#     print("1等于10")



# a = int(input())
# if a > 10:
#     print(f"{a}大于10")
# elif a == 10:
#     print(f"{a}等于10")
# else:
#     print(f"{a}小于10")



# s = input()
# x1 = s.split(" ")
# a = int(x1[0])
# b = int(x1[1])
# c =int(x1[2])
#
# if a<=b<=c or c<=b<=a:
#     print(b)
# elif b<=a<=c or c<=a<=b:
#     print(a)
# else:
#     print(c)
#




# s = int(input())
# if s>0:
#     if s%2==0:
#         print("Y")
#     else:
#         print("N")


# s =input()
# n = int(s)
# if n >0:
#     if 10<=n and n<=99:
#         print("YES")
#     else:
#         print("NO")


# a, b = map(int, input().split())
# min_value = min(a, b)
# print(min_value)




# numbers = [1,2,3,4,5]
# def doubler(n):
#     return n*2
#
# result = map(doubler, numbers)
# print(result)
# print(list(result))



# a = int(input())
# a = a//10
# match a:
#     case 10:
#         print("A")
#     case 9:
#         print("A")
#     case 8:
#         print("B")
#     case 7:
#         print("C")
#     case 6:
#         print("D")
#     case 5:
#         print("E")


# s = input()
# s = s.lower()
# if s =='a' or s =='o' or s =='i' or s =='e' or s =='u':
#     print("Y")
# else:
#     print("NO")



# x = ["+","-","*","/"]
# y = ["=",">","<"]
# z =["!","|","^","&"]
# s  = input()
# if s in x:
#     print("Arithmetic operators")
# elif s in y:
#     print("Relational operators")
# elif s in z:
#     print("Logical operators ")
# elif ord(s) >=ord("a") and ord(s) <= ord("z"):
#     print("Lowercase letter")
# elif ord(s) >=ord("A") and ord(s) <= ord("Z"):
#     print("Capital letter")
# elif ord(s) >=ord("0") and ord(s) <= ord("9"):
#     print("Number")
# else:
#     print("Other character")


# price = 1
# while price <= 100:
#     print(price)
#     price += 2


# n = 100
# sum = 0
# i = 1
# while(i <= n):
#     sum = sum + i
#     i = i + 1
# print(sum)
# n = int(input())
# for i in range(n,0,-1):
#         print(i,end =' ')
#


# n = int(input())
# s = 0
# m = input().split(' ')
#
# for i in range(len(m)):
#         a = float(m[i])
#         s =s +a
# print("{:.2f}".format(s/n))

# print("{:<5d} {:>5d}".format(455, 455))
# print("{:<5d} {:>5d}".format(-123, -123))
# print("{:<5d} {:>5d}".format(987654, 987654))


# a = 1
# A = 2
# print(a)
# print(A)
# 区分大小写



