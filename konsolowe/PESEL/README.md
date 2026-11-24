# Sprawdzanie poprawności numeru PESEL
Aplikacja konsolowa napisana w języku C#, weryfikująca płeć oraz sumę kontrolną 11-cyfrowego numeru PESEL.

## Działanie programu
Program przechowuje numer PESEL w zmiennej tekstowej i przekazuje go do dwóch osobnych metod klasy `Pesel`:
* `SprawdzPlec` – analizuje dziesiątą cyfrę numeru PESEL i zwraca znak `'K'` dla cyfry parzystej (kobieta) lub `'M'` dla nieparzystej (mężczyzna).
* `SprawdzSumeKontrolna` – mnoży pierwsze dziesięć cyfr przez przypisane im wagi, sumuje uzyskane iloczyny i wyznacza cyfrę kontrolną za pomocą operacji modulo 10. Następnie porównuje wynik z jedenastą cyfrą numeru PESEL, zwracając wartość logiczną `true` lub `false`.