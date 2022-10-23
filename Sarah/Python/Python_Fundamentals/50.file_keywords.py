
f= open('hello.cpp','t+w',encoding='utf-8')
f.write('#include<iostream>\nusing namespace std\nint main()\n{\ncout<<"Hello World!";\nreturn 0;\n}')
f.close()
