TAT�L UYGULAMASI
Bu uygulama, kullan�c�n�n planlayaca�� 3 g�nl�k bir tatil i�in maliyet hesaplamas�na yard�mc� olur. Kullan�c�dan lokasyon, ki�i say�s� ve ula��m tercihi gibi bilgiler al�nd�ktan sonra toplam tatil maliyeti hesaplan�r ve ekranda g�sterilir.

Kullan�m Ad�mlar�
Tatil Lokasyonu Se�imi:

Kullan�c�, tatilini yapmak istedi�i lokasyonu se�er. Lokasyonlar �unlard�r:
Bodrum (Ba�lang�� fiyat�: 4000 TL)
Marmaris (Ba�lang�� fiyat�: 3000 TL)
�e�me (Ba�lang�� fiyat�: 5000 TL)
Ki�i Say�s� Bilgisi:

Kullan�c�, ka� ki�i i�in tatil planlad���n� belirtir. Bu bilgi, toplam maliyetin hesaplanmas�nda kullan�l�r.
Ula��m Se�enekleri:

Kullan�c�, tatiline hangi ula��m arac�yla gitmek istedi�ini se�er:
Kara Yolu (Ki�i ba�� ula��m �creti: 1500 TL)
Hava Yolu (Ki�i ba�� ula��m �creti: 4000 TL)
Hesaplama:

Se�ilen lokasyon, ki�i say�s� ve ula��m bilgilerine g�re toplam tatil maliyeti hesaplan�r.
Sonu�:

Kullan�c�n�n se�ti�i lokasyon, ki�i say�s�, ula��m tercihi ve toplam maliyet bilgileri ekranda g�sterilir.
Tekrar Tatil Planlama:

Kullan�c�ya ba�ka bir tatil planlamak isteyip istemedi�i sorulur. �sterse yeniden planlama yapabilir, istemezse uygulama sonland�r�l�r.
�rnek �al��ma Senaryosu
Uygulama, kullan�c�n�n tatil yapmak istedi�i yeri sorar. �rne�in, kullan�c� "Bodrum" yazarsa:

rust
Kodu kopyala
Bodrum'un e�siz plajlar�nda tatilin keyfini ��karabilirsiniz.
Kullan�c� ka� ki�i i�in tatil planlad���n� belirtir. �rne�in, 3 ki�i i�in:

Kodu kopyala
3 ki�ilik bir tatil planl�yorsunuz.
Ula��m tercihini sorar. Kullan�c� kara yolu (1) veya hava yolu (2) aras�nda se�im yapar. �rne�in, kara yolunu se�erse:

yaml
Kodu kopyala
Ula��m tercihiniz: Kara Yolu
Sonu�:

Toplam tatil maliyeti hesaplan�r ve ekranda g�sterilir.
yaml
Kodu kopyala
Toplam maliyet: 16000 TL
Ba�ka bir tatil planlamak isteyip istemedi�i sorulur.

Geli�tirme Notlar�
Kullan�c�dan al�nan lokasyon verisi b�y�k/k���k harf duyarl�l���n� g�zetmeden i�lenir.
Yanl�� giri�ler i�in kullan�c�lara hata mesaj� verilerek do�ru bilgiyi yeniden girmesi istenir.
Bu proje, basit bir tatil planlama sim�lasyonu olup, farkl� lokasyonlar ve ula��m se�enekleriyle kullan�c�lara tatil masraflar�n� tahmin etme imkan� sunar.