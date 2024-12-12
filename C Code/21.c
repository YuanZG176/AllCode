#include <stdio.h>

int main(){
	int f;
	int i;
	for(i=100;i<=200;i++){
		f=1;
		int k;
		for(k=2;i<i;k++){
			if(i%k==0){
				f=0;break;
			}
		}
		if(f==1)printf("%d ",i);
	}

    return 0;
}

