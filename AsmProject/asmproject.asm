;Szymon Walasik gr5 sekcja 1



.data
.code
;procedura opis
;prametry wej�ciowe: 
;parametry wyj�ciowe: rax - co 




yes proc a:BYTE, b:BYTE, c:BYTE, d:BYTE

pinsrb xmm0, rcx, 0				;wpisanie argumentu a (rcx) do rejestru xmm0 na miejsce 0
pinsrb xmm0, rdx, 1				;wpisanie argumentu b (rdx) do rejestru xmm0 na miejsce 1

pinsrb xmm1, r8, 0				;wpisanie argumentu c (rcx) do rejestru xmm1 na miejsce 0
pinsrb xmm1, r9, 1				;wpisanie argumentu d (rcx) do rejestru xmm1 na miejsce 1


psubb xmm0, xmm1				;obliczanie sumy r�nic warto�ci obu rejestr�w xmm0, xmm1


pabsb xmm1, xmm0				;obliczenie warto�ci absolutnej xmm1

pextrb rax, xmm1, 1				;wyci�gni�cie z xmm1 drugiej warto�ci i wpisanie jej do rax
pinsrb xmm0, rax, 0				;wpisanie do pierwszej warto�ci xmm0 warto�� z rax

paddb xmm0, xmm1				;zsumowanie dw�ch wektor�w xmm0 i xmm1

pextrb rax, xmm0, 0;			;wyci�gni�cie z xmm0 pierwszej warto�ci i wpisanie jej do rax

mov r8, 0ffffh					;wpisanie warto�ci 255 do r8
cmovc rax, r8					;sprawdzenie, czy warto�� w rax jest >255, je�li tak - wstawia warto�� 255 do rax

ret								;zwraca warto�� rax

yes endp
END