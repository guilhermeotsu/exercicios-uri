#include<iostream>

using namespace std;

int main(){
	
	int n, x, y, s = 0;
	
	cin >> n;
	
	for(int i = 1; i <= n; i++){
		cin >> x >> y;
		if(x % 2 != 0){
			s += x;
		} else {
			x += 1;
			s += x;
		}
		for(int i = 0; i < y-1; i++){
			x += 2;
			s +=x;
		}
		cout << s << endl;
		s = 0;
	}
}
