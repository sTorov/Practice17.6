# Practice17.6

## Task

Дан код:

    public class Account
    {
       // тип учетной записи
       public string Type { get; set; }
      
       // баланс учетной записи
       public double Balance { get; set; }
      
       // процентная ставка
       public double Interest { get; set; }
    }

___

    public static class Calculator 
    { 
       // Метод для расчета процентной ставки
       public static void CalculateInterest(Account account) 
       { 
           if (account.Type == "Обычный") 
           { 
               // расчет процентной ставки обычного аккаунта по правилам банка
                   account.Interest = account.Balance * 0.4;
    
                   if (account.Balance < 1000)
                       account.Interest -= account.Balance * 0.2;

                   if (account.Balance < 50000)
                       account.Interest -= account.Balance * 0.4;
           } 
           else if(account.Type == "Зарплатный") 
           { 
               // расчет процентной ставк зарплатного аккаунта по правилам банка
               account.Interest = account.Balance * 0.5;
           } 
       }
    } 

Написать свой вариант рефакторинга кода в соответствии с Принципом открытости-закрытости.
___
***Описание решения***

В данном решении представлено 2 проекта, в которых был произведен рефакторинг одного и того же кода в соответствии с Принципом открытости-закрытости.

Проекты:

- *Task* - при рефакторинге использовался абстрактный класс `Account`, являющийся базовым для всех аккаунтов, в котором был описан абстрактный метод для расчёта процентной ставки `CalculateInterest`.

- *TaskOtherVersion* - при рефакторинге использовался интерфейс для всех аккаунтов `IAccount`, в котором был описан метод для расчёта процентной ставки `CalculateInterest`.