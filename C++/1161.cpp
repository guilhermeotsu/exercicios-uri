#include<iostream>

using namespace std;

int main() {
	int x, y;
	long long sum1 = 1, sum = 1; 
	
	while(cin >> x >> y) { 	
		for(int i = 2; i <= x; i++){ 
			sum *= i;
		}
		for(int j = 2; j <= y; j++){ 
			sum1 *= j;
		}
		cout << sum1 + sum << endl;
		sum = 1; sum1 =1;
	}
}
