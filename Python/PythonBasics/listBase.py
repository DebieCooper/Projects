#Список
nums = [5, 7, 2, 4, 7, True, 5.2, "Hello", [5,7]]
print(nums[-1][1]) 

nums.append(100) #добавить в конец
print(nums)

nums.insert(1,False) #добавить по индексу со смещением
print(nums)

b = [5, 7, 8]
nums.extend(b) #добавить список в конец списка
print(nums)

numbers = [55,True, 6, 7, 6, 100] # сортировка
numbers.sort()
print(numbers)

numbers.pop()           #удаление последнего. pop(1) - удаление по индексу 1
numbers.remove(True)    #удаление по значению
print(numbers)

print(numbers.count(6)) #считает количество элементов равных 6 по значению
print(len(numbers))     #количество элементов в списке


nums = [5, 2, 7, "50", False]

for i in nums:
    print(i)
