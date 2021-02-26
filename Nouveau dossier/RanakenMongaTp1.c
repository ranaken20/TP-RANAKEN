#include <stdio.h>
#include <windows.h>
#include <sys/types.h>
#include <unistd.h>
 
int main(void)
{
  DWORD x,y,z,w;
 
  GetDiskFreeSpace("C:\\", &x, &y,&z, &w);

  printf("%lu Mo\n", z / 1024  * x / 1024 * y);
 
  printf("%lu Go\n", z / 1024  *x / 1024 * y  / 1024);
 int t1, t2 = GetTickCount();

int i, c=0;
 for (i=0; i<1000000000; i++)
 c++;
 t1 = GetTickCount();
printf("%d msc\n", t1-t2);

pid_t id = getpid();
printf("process ID = : %lun \n", id);

printf(" user name : %s\n", getenv("USERPROFILE"));
return 0;
}