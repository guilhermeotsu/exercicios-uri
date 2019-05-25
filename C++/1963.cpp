#include<stdio.h>
#include<iostream>

using namespace std;

int main(){
	double x, y;
	
	cin >> x >> y; 
	
	printf("%.2lf%%\n", y * 100 / x - 100);
	
	return 0;
}	
