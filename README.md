# Yakıt Takip
Proje de, Türpak sistemi bünyesinde benzin istasyonundan gelen ham veri(benzin bilgisi) ve Arvento sistemi bünyesinde araç üzerindeki takibi sağlayan motor ile kontak arasında bulunan cihazdan gelen ham veri(kilometre bilgisi)nin bir araya getirilerek işlenip raporlanması olarak tanımlanabilir.



--ANASAYFA

Anasayfa içerisinde kullanıcıya şirketin sahip olduğu Araç,Personel ve Görev Tanımlamalarının güncel sayısı ve buna ek olarak  grafikler ile ;araçların en çok mesafe kat edilmesi bakımından ilk 5 sıralaması analiz edilip gösterilmekte,En çok yakıt tüketen aracların Id’si ve toplam yakıt tüketimi görüntülenebilmekte  ve Görev tanımlamalarının aylık olarak en çok görev gerçekleştiren 5 personel görev sayıları ve isimleri görüntülenmektedir

![anasayfa](https://user-images.githubusercontent.com/26030084/34906811-cd4a3794-f885-11e7-9f9a-38e568daa1e9.png)

--ARAC SAYFASI

Bu sayfa içerisinde 2 farklı analiz raporu kullanıcıya sunulmaktadır.Araç listesi ve  en çok mesafe kat eden 10 araca ait id ve mesafe bilgisi km tipinde görüntülenmektedir.
Araç listesi içerisinde her araca ait toplam emsafe ve toplam yakıt tüketim verisi store procedur kullanılarak bir dfada getirltilmektedir.Ve sonuç modal ile görüntülenmektedir.



![arac_2](https://user-images.githubusercontent.com/26030084/34906833-32535d14-f886-11e7-8a7e-f9a8c3e91394.png)

![arac_1](https://user-images.githubusercontent.com/26030084/34906832-323017be-f886-11e7-9255-f1995a3ad4ac.png)


--PERSONEL SAYFASI

Bu sayfa içerisinde Personel listesinin yanısıra ay içerisinde en çok görev alan 10 personel bilgisi ve Personellerin görevleri ,görevlerine bağlı olarak kullandıkları araç id listesi olmak üzere Personeller için 3 farklı analiz seçeneği sunulmaktadır.

İlk analiz en çok görev tanımlaması bulunan personeller ve görev sayılarının grafiğidir.
İkinci analizde personellerin araç ve görev tanımalmalarının analiz listesi bulunmaktadır.
Son tablo da ise şirket içerisindeki tüm personellerin listesi getirilmektedir.

![personel](https://user-images.githubusercontent.com/26030084/34906841-763700d0-f886-11e7-8669-af03dfa61437.png)

![personel_2](https://user-images.githubusercontent.com/26030084/34906842-775386a0-f886-11e7-9ec5-21b041da6a0b.png)

![perseonel_3](https://user-images.githubusercontent.com/26030084/34906843-7a3dafa8-f886-11e7-8890-d0829ba70261.png)




--YAKIT BİLGİSİ SAYFASI


Bu sayfa içerisinde ise her araca ait yakıt tüketim verileri görüntülenmekte ve ayrıca yakıt tüketimini fazla gerçekleştiren ilk 10 aracın analizi de gösterilmektedir.
Alt kısımda ise araçların yakıt tüketimleri detaylı içeren bir liste sunulmaktadır.


![arac](https://user-images.githubusercontent.com/26030084/34906856-aafadb70-f886-11e7-9fda-24f776d0c511.png)


![yakit](https://user-images.githubusercontent.com/26030084/34906855-aa37ac86-f886-11e7-9573-d6f62664e8b8.png)


--GÖREVLER SAYFASI

Görevler sayfasında her personel ve araca tanımlı görev ve bu görevlerin süreleri listelenmekte ve her görevden kaç adet bulunduğuna dair bir analiz grafiği kullanıcıya sunulmaktadır.

![gorev](https://user-images.githubusercontent.com/26030084/34906870-f178d1e2-f886-11e7-881f-80bf101f8c61.png)

![g_2](https://user-images.githubusercontent.com/26030084/34906872-fd0153cc-f886-11e7-817a-d377b98aa335.png)



--MARKA VERSİYON BİLGİLERİ SAYFASI

Her markaya ait aracın ortalma yakıt tüketimi,saatlik yakıt tüketimi,yakıt tankı kapasitesi ve sahip firma bilgileri listelenmekte ve bunun dışında markalara baglı ortalama ve saatlik yakıt tüketimi ile ilgili analiz grafiği sunulmaktadır.


![marka](https://user-images.githubusercontent.com/26030084/34906878-1d200518-f887-11e7-93f9-3e5c60afb73e.png)

![m_2](https://user-images.githubusercontent.com/26030084/34906879-1fd418bc-f887-11e7-9797-358b21e702bd.png)


--MODEL DAGILIMLARI SAYFASI

Bu sayfa içerisinde ise her markanın toplam araçlar içerisinde kaç adet bulunduğu yüzdelik olarak  belirtilmektedir.


![dagilim](https://user-images.githubusercontent.com/26030084/34906888-3c0cec3e-f887-11e7-81f1-4a7699dfd77b.png)



