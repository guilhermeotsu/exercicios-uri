#include<iostream>

using namespace std;

int main() {
	int n, x, y, z, sum;
	
	cin >> n;
	
	while(true){
		if(n==0) 
		break;
		
		cin >> x >> y;
		
		if(x > y){
			z = x;
			x = y;
			y = z;
		}
		sum = 0;
		for(int i = x+1; i < y; i++){
			if(i%2 !=0){
				sum +=i;
			}
		}
		cout << sum << endl;
		n--;
		
	}
}
