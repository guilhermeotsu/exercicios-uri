#include <iostream>
#include <math.h>

using namespace std;

int main(){
    int x, y;
    
    int c;
    
    cin >> x;
    
    for(int i = 0; i < x; i++){
            cin >> y;          
            c = 0;
            for(int i = 1; i < sqrt(y); i++){
                    if(y % i == 0) {					
					 c++;
                    }
					if(c > 1) {                  	
					break;
				}
            }
            
            if(c == 1) {			
			cout << y << " eh primo" << endl;
            }else{			
			cout << y << " nao eh primo" << endl;
		}
    }
    return 0;
}
