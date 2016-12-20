#include <unistd.h>
#include <stdio.h>
#include <dirent.h>
#include <sys/stat.h>
#include <sys/types.h>
#include <string.h>
int total;
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
        {
            double s = fileStat.st_size;
            total += s;
            if(s>=1073741824)
            {
                s = s/1073741824;
                fprintf(f,"%s\t%d\t%.2f GB\n",dirName,fileStat.st_size,s);
            }
            else if(s>=1048576)
            {
                s = s/1048576;
                fprintf(f,"%s\t%d\t%.2f MB\n",dirName,fileStat.st_size,s);
            }
            else if(s>=1024)
            {
                s = s/1024;
                fprintf(f,"%s\t%d\t%.2f KB\n",dirName,fileStat.st_size,s);
            }
            else
            {
                fprintf(f,"%s\t%d\t%.0f Byte\n",dirName,fileStat.st_size,s);
            }
        }
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
    fprintf(f,"Directory\tSize (in byte)\tSize (Simpified)\n");
    char argv[] = "D:\\leap-motion-game\\Game 1 Full Version";
    struct stat fileStat;
    if(stat(argv,&fileStat)<0)
        return 1;
    listdir(argv, f);
    double s = total;
    if(s>=1073741824)
    {
        s = s/1073741824;
        fprintf(f,"Total Size\t%d\t%.2f GB\n",total,s);
    }
    else if(s>=1048576)
    {
        s = s/1048576;
        fprintf(f,"Total Size\t%d\t%.2f MB\n",total,s);
    }
    else if(s>=1024)
    {
        s = s/1024;
        fprintf(f,"Total Size\t%d\t%.2f KB\n",total,s);

    }
    else
    {
        fprintf(f,"Total Size\t%d\t%.0f byte\n",total,s);
    }
    fclose(f);
}
