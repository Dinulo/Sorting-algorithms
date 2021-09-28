import random
import timeit

print("Bubblesort") #welcome
#get user inputs for size and range
size = int(input("Enter array size (int): "))
bottom = int(input("Enter bottom of range (int): "))
top = int(input("Enter top of range (int): "))

#declare empty array to order later and append random numbers to it
numbers = []
for i in range(size):
    numbers.append(random.randint(bottom, top))
print("Your random array: ", numbers) # print array to user

#start timing
startTime = timeit.default_timer()

#for index 0 - length-1, compare two numbers and if left is bigger, swap them using the temporary slot.
#if all numbers are compared and no swap was made, swapped stays false and the loop terminates
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

#stop time and display sorted array with execution time
stopTime = timeit.default_timer()
print("Sorted: ",numbers)
print("Execution time: ", stopTime-startTime)
