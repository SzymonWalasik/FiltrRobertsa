;Szymon Walasik gr5 sekcja 1



.data
.code
;procedura opis
;prametry wejœciowe: 
;parametry wyjœciowe: rax - co 




yes proc a:BYTE, b:BYTE, c:BYTE, d:BYTE

pinsrb xmm0, rcx, 0				;wpisanie argumentu a (rcx) do rejestru xmm0 na miejsce 0
pinsrb xmm0, rdx, 1				;wpisanie argumentu b (rdx) do rejestru xmm0 na miejsce 1

pinsrb xmm1, r8, 0				;wpisanie argumentu c (rcx) do rejestru xmm1 na miejsce 0
pinsrb xmm1, r9, 1				;wpisanie argumentu d (rcx) do rejestru xmm1 na miejsce 1


psubb xmm0, xmm1				;obliczanie sumy ró¿nic wartoœci obu rejestrów xmm0, xmm1


pabsb xmm1, xmm0				;obliczenie wartoœci absolutnej xmm1

pextrb rax, xmm1, 1				;wyci¹gniêcie z xmm1 drugiej wartoœci i wpisanie jej do rax
pinsrb xmm0, rax, 0				;wpisanie do pierwszej wartoœci xmm0 wartoœæ z rax

paddb xmm0, xmm1				;zsumowanie dwóch wektorów xmm0 i xmm1

pextrb rax, xmm0, 0;			;wyci¹gniêcie z xmm0 pierwszej wartoœci i wpisanie jej do rax

mov r8, 0ffffh					;wpisanie wartoœci 255 do r8
cmovc rax, r8					;sprawdzenie, czy wartoœæ w rax jest >255, jeœli tak - wstawia wartoœæ 255 do rax

ret								;zwraca wartoœæ rax

yes endp
END