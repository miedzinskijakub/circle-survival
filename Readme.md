# DaftMobile Recruitment

## Unity: Circle Survival

### Cel zadania

Stwórz grę mobilną typu arcade survival w silniku Unity. Gra ma zawierać dwa ekrany – menu oraz rozgrywkę.

---

### Core Loop gry

Rozgrywka polega na tapowaniu pojawiających się kulek. Każda kulka jest bombą – mamy ograniczony czas na tapnięcie w nią (rozbrojenie). Jeśli nie zdążymy tapnąć kulki – przegrywamy. Udane tapnięcie w kulkę powoduje jej usunięcie (zneutralizowanie). W czasie rozgrywki kulki pojawiają się coraz szybciej i mają coraz mniejszy czas do wybuchu (dzięki temu poziom trudności rośnie i nie można grać w nieskończoność).

Dodatkowo pojawia się inny typ kulek – kulki *bomby*. *Bomb* nie wolno tapować – tapnięcie w bombę powoduje automatyczne przegranie gry. Bomby automatycznie znikają jeśli nie zostaną tapnięte (po 3 sekundach).

- Na polu rozgrywki spawnują się kulki (w losowych miejscach).
- Kulki nie mogą na siebie nachodzić.
- Każda kulka losuje czas do wybuchu (początkowo z przedziału 2 - 4 sekundy)
- Kiedy gracz tapnie kulkę przed upłynięciem czasu – kulka znika (efekt graficzny i dźwiękowy mile widziany)
- Kiedy gracz nie zdąży tapnąć kulki do upłynięcia czasu – przegrywa (efekt graficzny i dźwiękowy mile widziany)
- Poziom trudności gry cały czas rośnie w trakcie rozgrywki
- Około 10% kulek, które się spawnują, to **bomby**
- Tapnięcie w bombę powoduje automatyczne przegranie gry (efekt graficzny i dźwiękowy mile widziany)
- Po zakończeniu gry pokazujemy graczowi informację, że przegrał, jego wynik (ilość "zbitych" kulek) oraz informację czy zdobył High Score
- Po zaakceptowaniu tej informacji gracz wraca na główny ekran menu

### Ekran rozgrywki

- Ekran gry jest podzielony na HUD oraz planszę z rozgrywką
- HUD zawiera informację o aktualnym czasie rozgrywki (ile minęło od początku gry) i zdobytych punktach

### Ekran menu

Zawiera
- Tytuł gry
- Informację o najlepszym wyniku
- Przycisk `PLAY`

### Dodatkowe wymagania / informacje

- Rekord powinien być zapisywany pomiędzy uruchomieniami aplikacji (użyj dowolnego mechanizmu zapisu)
- Rozgrywka powinna wydawać się "naturalna" i łatwa do zrozumienia.
- Użyj najnowszej wersji Unity 2020 LTS lub 2021 LTS
- Gra powinna być możliwa do zbudowania zarówno na iOS jak i Android (i oczywiście wspierać interakcję przy użyciu dotyku)
- Żadne animacje ani dodatkowe elementy (np. particles) nie są wymagane, ale na pewno pozytywnie wpłyną na ocenę
- Częścią zadania jest takie zaprojektowanie niedopowiedzianych w zadaniu elementów, żeby rozgrywka była naturalna i przyjemna
- W szczególności częścią zadania jest dostosowanie krzywej poziomu trudności tak, aby rozgrywka była przyjemna, nie dłużyła się, a jednocześnie stanowiła wyzwanie

### Ocenie podlegają:

- Implementacja wszystkich funkcjonalności
- Naturalność i atrakcyjność rozgrywki
- Styl i przejrzystość kodu
- Przywiązywanie uwagi do szczegółów

## Spawnowanie kulek

Dodatkowo zwróć szczególną uwagę na implementację algorytmu spawnującego kulki. Jest tu możliwych kilka rozwiązań. Najważniejsze oczywiście jest, żeby działanie było poprawne, tzn. żeby kulki nie wychodziły poza ekran i żeby na siebie nie nachodziły. Ale bonusowe punkty są dostępne za rozwiązanie wydajne czasowo i pamięciowo, niebazujące na gridzie i gwarantujące, że gra się nie zapętli.

## Wygląd kulek

Celowo nie wspomnieliśmy w opisie zadania jak kulki mają wyglądać. Możesz się tu wykazać swoją kreatywnością, ale pamiętaj, że najważniejsza w wyglądzie gry jest jej czytelność, więc zadbaj o to, żeby przekazać informację o typie kulki (bomba/zwykła) i czasie jaki tej kulce pozostał do wybuchu. Spróbuj znaleźć też rozwiązanie które nie zabierze Ci za dużo czasu - gra ma przede wszystkim działać, wygląd jest drugorzędny.

### Dostarczenie

Swoje rozwiązanie prześlij commitując w tym repozytorium (na branchu `main`). Push odpowiednich commitów do tego repozytorium jest **wystarczający**. Alternatywnie, jeśli nie czujesz się pewnie z gitem, prześlij plik `.zip` ze spakowanym całym folderem projektu (kod, a nie zbudowaną grę).

---

## Powodzenia! 👩‍💻💪

