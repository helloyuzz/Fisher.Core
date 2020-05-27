# Fisher.Core

﻿**create a new repository:**
```md
echo "# Fisher.Core" >> README.md
git init
git add README.md
git commit -m "first commit"
git remote add origin https://github.com/helloyuzz/Fisher.Core.git
git push -u origin master
```


**push an existing repository:**
```md
git remote add origin https://github.com/helloyuzz/Fisher.Core.git
git push -u origin master
```


### Only Two Methods:
```C#
SaveResult  saveResult  = Fisher.Save();  ==> db.Insert();
                                          ==> db.Update();
                                          ==> db.Delete();
               
QueryResult queryResult = Fisher.Query(); ==> db.Select();
```

Easy to use;
