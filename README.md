Итоговая проверочная работа.

1. Создать репозиторий на GitHub 
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы
выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README. md)
4. Написать программу, решающую поставленную задачу 
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залитс
одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах) 

Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
['1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []

Описание решения: 

Объявил первый массив строк (задан на старте выполнения алгоритма), создал метод и вывел массив заданных строк в терминал.
Объявил второй массив, равный длинне первого массива. Создал метод, в котором цикл соразмерный длине массива, внутри этого цикла сделал проверку условия,
в котором проверяется каждая строка массива поэлементно (oneArray[i].Lenght <= 3). Если условие выполняется, то элемент первого массива добавляется
в count второго массива (twoArray[count] = oneArray[i]) 
Переменная count увеличивается на 1 и возвращается к циклу for в котором i увеличивается на 1. И так проверяется до конца.
После окончания проверки массива строк на условие вывел полученный массив строк в терминал.