## Описание решения
1. Задаем массив **array**.
2. Выводим в консоль заданный массив array с возможностью продолжения строки результатом.
3. Инициализируем пустую строку **A**.
4. Заходим в цикл, в котором проходимся по каждому элементу массива array:
    4.1. проверяем длину каждого элемента на условие **"меньше или равно 3"**; 
	4.2. если условие выполняется, добавляем текущий элемент с пробелом в строку **А**; 
	4.3. инкрементируем счетчик **i**.
5. Выходим из цикла, как только счетчик превышает длину массива array.
6. Инициализируем новый массив **newArray**, разбивая строку **А** на элементы по пробелам.
7. Добавляем вывод в консоль, описанный выше, новым массивом **newArray**, удалив все запятые и пробелы с конца строки.