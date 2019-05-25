#include<iostream>

using namespace std; 

int main() { 

	int x,y, v = 0; 
	
	while(cin >> x) { 
		for(int i = 0; i < x; i++){ 
			cin >> y;
			if(y > v) {
				v = y;
			}
		}
		if(v < 10) { 
		cout << "1" << endl;
		}else if (v >= 10 && v < 20){ 
		cout << "2" << endl;
		}else if(v >= 20){ 
		cout << "3" << endl;
		}
		v = 0;
	}
}
