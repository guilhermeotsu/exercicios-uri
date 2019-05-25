#include <iostream>

using namespace std;

int main(){
    double x = 0, y = 1;
    
    while(x <= 2.1){
            cout << "I=" << x << " " << "J=" << y+x << endl
           	     << "I=" << x << " " << "J=" << y+1+x << endl
               	<< "I=" << x << " " << "J=" << y+2+x << endl;
            x+= 0.2;
    }
    return 0;
}
