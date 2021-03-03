﻿Представьте себе, что будущее наступило и некий автоматизированный механизм умеет 
наполнять витрину (и лавки) товарами, а также размещать новые лавки.

Необходимо реализовать консольное приложение, которое умеет работать с лавками и товарами.

Возможности программы:
#Работа с витринами

    Создать новую витрину с названием и объемом. Объем - сколько товаров может поместиться, у каждого
    товара свой объем.
    Отредактировать витрину. При смене объема, если товары уже расположены на витрине и их суммарный 
    объем больше нового значения объема витрины, программа не позволять это сделать и сообщать ошибку.
    Удалить витрину. Если товары расположены на витрине, то программа не позволять это сделать и 
    сообщать ошибку.
    В каждую созданную витрину можно добавить товар. При этом если товар не помещается, 
    программа не позволять это сделать и сообщать ошибку

#Работа с товарами

    Создать товар, который можно расположить на витрине.
    Отредактировать товар
    Удалить товар

#Модели
Витрина:

    Идентификатор (порядковый номер, чтобы однозначно идентифицировать витрину)
    Название
    Объем
    Дата создания
    Дата удаления

Товар:

    Идентификатор (порядковый номер, чтобы однозначно идентифицировать товар)
    Название
    Занимаемый объем

Товары на витрине:

    Идентификатор (порядковый номер, чтобы однозначно идентифицировать товар на витрине)
    Идентификатор витрины (порядковый номер, чтобы однозначно идентифицировать витрину)
    Идентификатор товара (порядковый номер, чтобы однозначно идентифицировать товар)
    Кол-во товара - в целом можно и сразу считать объем, если посчитаешь это удобным
    Стоимость товара

В качестве товаров может быть все что угодно (можно пофантазировать)

В программе должен быть интерфейс взаимодействия с пользователем в виде простого консольного меню.
При выполнении операций программа не должна закрываться, для выхода из программы следует сделать
отдельную операцию. При выполнении задания нужно стараться использовать интерфейсы для каждой операции,
чтобы в последствии реализацию операции можно было легко подменить.

Пример: IPlaceProduct - с методом Place(Product product);
реализация может быть PlaceProduct - который будет размещать товар в коллекции в памяти (в лист)
реализация может быть PlaceProductToFile - который будет размещать товар в памяти и сохранять его в файлике.
Работу с файликом делать не нужно, про это еще будет занятие. Для начала поработайте с данными в памяти. 
Нужно что у вас все прочно осело в голове. 