userList = []
listLength = int(input("Введите размерность списка: "))

for i in range(listLength):
    print(f"Введите элемент списка #{i}: ")
    userList.append(input())
print(userList)
