#include <unistd.h>
#include <stdio.h>
#include <dirent.h>
#include <sys/stat.h>
#include <sys/types.h>
#include <string.h>

void listdir(const char *name, FILE *f)
{

    DIR *dir;
    struct dirent *entry;
    struct stat fileStat;
    if (!(dir = opendir(name)))
        return;
    printf("%s\n", name);
    while (entry = readdir(dir))
    {
        char path[1024];
        char dirName[1024];
        int len = snprintf(path, sizeof(path)-1, "%s/%s", name, entry->d_name);
        strcpy(dirName,"");
        strcat(dirName,name);
        strcat(dirName,"/");
        strcat(dirName,entry->d_name);
        stat(dirName,&fileStat);
       // printf("%s\n",dirName);
        //printf("Size: %d bytes\n",fileStat.st_size);
        if(!S_ISDIR(fileStat.st_mode))
        fprintf(f,"%s\t%d\n",dirName,fileStat.st_size);
        path[len] = 0;
        if (strcmp(entry->d_name, ".") == 0 || strcmp(entry->d_name, "..") == 0)
            continue;
        listdir(path,f);

    }
    closedir(dir);
}

int main()
{
    FILE *f = fopen("output.txt","w");
    char argv[] = "c:\\Algorithm Design";
    //char argv[] = "D:\\leap-motion-game\\Game 1 Full Version";
    struct stat fileStat;
    if(stat(argv,&fileStat)<0)
        return 1;
    listdir(argv, f);
    fclose(f);
}
