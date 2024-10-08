TATÝL UYGULAMASI
Bu uygulama, kullanýcýnýn planlayacaðý 3 günlük bir tatil için maliyet hesaplamasýna yardýmcý olur. Kullanýcýdan lokasyon, kiþi sayýsý ve ulaþým tercihi gibi bilgiler alýndýktan sonra toplam tatil maliyeti hesaplanýr ve ekranda gösterilir.

Kullaným Adýmlarý
Tatil Lokasyonu Seçimi:

Kullanýcý, tatilini yapmak istediði lokasyonu seçer. Lokasyonlar þunlardýr:
Bodrum (Baþlangýç fiyatý: 4000 TL)
Marmaris (Baþlangýç fiyatý: 3000 TL)
Çeþme (Baþlangýç fiyatý: 5000 TL)
Kiþi Sayýsý Bilgisi:

Kullanýcý, kaç kiþi için tatil planladýðýný belirtir. Bu bilgi, toplam maliyetin hesaplanmasýnda kullanýlýr.
Ulaþým Seçenekleri:

Kullanýcý, tatiline hangi ulaþým aracýyla gitmek istediðini seçer:
Kara Yolu (Kiþi baþý ulaþým ücreti: 1500 TL)
Hava Yolu (Kiþi baþý ulaþým ücreti: 4000 TL)
Hesaplama:

Seçilen lokasyon, kiþi sayýsý ve ulaþým bilgilerine göre toplam tatil maliyeti hesaplanýr.
Sonuç:

Kullanýcýnýn seçtiði lokasyon, kiþi sayýsý, ulaþým tercihi ve toplam maliyet bilgileri ekranda gösterilir.
Tekrar Tatil Planlama:

Kullanýcýya baþka bir tatil planlamak isteyip istemediði sorulur. Ýsterse yeniden planlama yapabilir, istemezse uygulama sonlandýrýlýr.
Örnek Çalýþma Senaryosu
Uygulama, kullanýcýnýn tatil yapmak istediði yeri sorar. Örneðin, kullanýcý "Bodrum" yazarsa:

rust
Kodu kopyala
Bodrum'un eþsiz plajlarýnda tatilin keyfini çýkarabilirsiniz.
Kullanýcý kaç kiþi için tatil planladýðýný belirtir. Örneðin, 3 kiþi için:

Kodu kopyala
3 kiþilik bir tatil planlýyorsunuz.
Ulaþým tercihini sorar. Kullanýcý kara yolu (1) veya hava yolu (2) arasýnda seçim yapar. Örneðin, kara yolunu seçerse:

yaml
Kodu kopyala
Ulaþým tercihiniz: Kara Yolu
Sonuç:

Toplam tatil maliyeti hesaplanýr ve ekranda gösterilir.
yaml
Kodu kopyala
Toplam maliyet: 16000 TL
Baþka bir tatil planlamak isteyip istemediði sorulur.

Geliþtirme Notlarý
Kullanýcýdan alýnan lokasyon verisi büyük/küçük harf duyarlýlýðýný gözetmeden iþlenir.
Yanlýþ giriþler için kullanýcýlara hata mesajý verilerek doðru bilgiyi yeniden girmesi istenir.
Bu proje, basit bir tatil planlama simülasyonu olup, farklý lokasyonlar ve ulaþým seçenekleriyle kullanýcýlara tatil masraflarýný tahmin etme imkaný sunar.