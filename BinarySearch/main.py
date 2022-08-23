from random import randint

# x = randint(0, 100)

# метод последовательного перебора
# count = 0
# for i in range(0, 101):
#     count += 1
#     if i == x:
#         print ("число найдено!")
#         break

# print("Загаданное число: ", x, "и для поиска потребовалось ", count, "итераций")

# метод случайного отгадывания
# count = 1
# y = randint(0, 100)
# while x!=y:
#     y = randint(0, 100)
#     count += 1

# print("Загаданное число: ", x, "и для поиска потребовалось ", count, "итераций")

# алгоритм бинарного поиска вручную
# count = 1
# print("Угадай число от 0 до 100!")
# y = int(input('Введи число:'))
# while x!= y:
#     if x < y: print('искомое число меньше')
#     else: print('искомое число больше')
#     y = int(input('Введи число:'))
#     count += 1

# print("Загаданное число: ", x, "и для поиска потребовалось ", count, "итераций")

# алгоритм бинарного поиска автоматически
print("Угадай число от 0 до 100!")
left = 0
right = 100000000
x = randint(left, right)
mid =  (left + right) // 2
count = 1

while x!= mid:
    print(mid)
    if x < mid: 
        print('искомое число меньше')
        right = mid - 1
    else: 
        print('искомое число больше')
        left = mid + 1
    mid = (left + right) // 2
    count += 1

print("Загаданное число: ", x, "и для поиска потребовалось ", count, "итераций")