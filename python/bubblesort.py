import random
import timeit

print("Bubblesort")
size = int(input("Enter array size (integer) : "))
bottom = int(input("Enter bottom of range: "))
top = int(input("Enter top of range : "))

numbers = []
for i in range(size):
    numbers.append(random.randint(bottom, top))
print("Your random array: ", numbers)

startTime = timeit.default_timer()
swapped = True
slot = 0
while swapped:
    swapped = False
    for i in range(len(numbers)-1):
        if numbers[i] > numbers[i+1]:

            slot = numbers[i]
            numbers[i] = numbers[i+1]
            numbers[i+1] = slot
            swapped = True

stopTime = timeit.default_timer()
print("Sorted: ",numbers)
print("Execution time: ", stopTime-startTime)
