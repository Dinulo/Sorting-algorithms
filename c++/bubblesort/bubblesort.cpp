#include <iostream>
#include <string>
#include <cstdlib>
#include <ctime>

using namespace std;

int main()
{
    int arraySize;
    int rangeMin;
    int rangeMax;

    cout << "Bubblesort";
    cout << "\nEnter array size: ";
    cin >> arraySize;
    cout << "\nEnter bottom of range: ";
    cin >> rangeMin;
    cout << "\nEnter top of range: ";
    cin >> rangeMax;

    int* randomNumbers = new int[arraySize];
    srand((unsigned)time(0));
    int randomNumber;
    int range = rangeMax - rangeMin - 1;
    for (int i = 0; i < arraySize; i++) {
        randomNumber = (rand() % range) + rangeMin;
        //cout << randomNumber << endl;
        randomNumbers[i] = randomNumber;
    }

    cout << "\nYour random array:" << endl;
    for (int i = 0; i <= arraySize-1; i++) {
        cout << randomNumbers[i] << " ";
    }


    /*uncomment when finished to free memory
    
    delete[] randomNumbers;
    
    */
}
