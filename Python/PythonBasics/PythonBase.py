path = r"C:\Python\name.txt"
print(path)

path = "C:\Python\name.txt"
print(path)

userName = "Tom"
userAge = 37
user = f"name: {userName}  age: {userAge}"
print(user)   # name: Tom  age: 37

name = input("Введите свое имя:")
age = int(input("Введите ваш возраст:"))
print(f"Ваше имя:{name} Возраст:{age}")

number = 0b101
print(f"Number = {number}")
print(f"Number = {number:0b}")


language = "russian"
daytime = "morning"
if language == "english":
    if daytime == "morning":
        print("Good morning")
    else:
        print("Good evening")
else:
    if daytime == "morning":
        print("Доброе утро")
    else:
        print("Добрый вечер")


for i in range(6):
    print(i)

for i in range(3, 8):
    print(i)

for i in range(1, 8, 2):
    print(i)


#Таблица умножения
i = 1
j = 1

while i < 10:
    while j < 10:
        print(i * j, end="\t")
        j += 1
    print("\n")
    j = 1
    i += 1
