#include<iostream>
#include<iomanip>
#include<stdio.h>

using namespace std; 

int main(){ 
	
	double n;
	double vet [100];
	
	cin >> n;
	printf("N[%d] = %.4f\n", 0, n);
	
	for(int i = 1; i < 100; i++){
		printf("N[%d] = %.4f\n", i, n);
		n /= 2.0;
	}
}
