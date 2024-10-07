**C# FORM UYGULAMASI**

![image](https://github.com/user-attachments/assets/84ad5002-5dbb-48c3-b644-48351e83c478)

**Projenin Amacı**

 Ders programı ilkokul, ortaokul, lise ve üniversite de kısaca eğitim öğretim hayatında öğrencilerin ve öğretmenlerin gerek okula gelme gerekse sınıf yoğunluğunu düzenlenmesi açısından önemli rol oynayan bir düzenleme çizelgesidir. 

Ders programı tasarlanırken öncelikle bazı esaslara dikkat edilmesi gerekir. İlk olarak gereklilik analizi yaparken program gereksinimleri, ihtiyaçları yazılmıştır. Gereklilik analizinden sonra kavramsal tasarımda ihtiyaçların giderilmesi maksadı ile tasarlanıp varlık kümeleri oluşturulmuştur. Bu varlık kümelerinde gereklilik analizinden yola çıkılarak yapılan araştırma ile varlık kümelerin isimleri belirlendi. Üçüncü aşamada mantıksal tasarım yapılır. Mantıksal tasarımda, varlık kümeleri arasındaki ilişkilerinden yola çıkılarak tablolara dönüştürülmüş halidir. 

Yukarıda belirtilen kurallara uygun olarak oluşturulan ders programı tasarımının, öğrenciler ve öğretim elemanları tarafından kullanılarak zaman, mekân ve plan karmaşasının önüne geçilmesi hedeflenmiştir. 

 **1-) GEREKLİLİK ANALİZİ**       

*Program gereksinimleri ihtiyaçları yapılan araştırma sonucunda aşağıda belirtildiği şekilde tespit edilmiştir.  

*Okuldaki şubelerin kayıt altına alınması, 

*Okuldaki sınıfların kayıt altına alınması, 

*Öğretmen bilgileri (isimleri ve branşları) kayıt altına alınması, 

*Derslerin kayıt altına alınması, 

*Ders sürelerin kayıt altına alınması, 

*Ders araları (teneffüslerin) kayıt altına alınması. 

**2-) KAVRAMSAL TASARIM** 

*Kavramsal tasarım aşağıdaki ihtiyaçların giderilmesi maksadıyla tasarlanmıştır. 

*Öğrencilerin programa kolaylıkla bakabilmek. 

*Öğretmen isimlerine kolay ve hızlı bir şekilde erişebilmek. 

*Öğretmenlerin hangi branşta ders vereceğini ulaşabilmek, 

*Hangi dersler olduğuna kolayca ulaşabilmek. 

*Ders sürelerine ve mola dakikalarına kolaylıkla ulaşılabilmek, 

*Hangi günlerde derslerin olabildiğine bakılabilmek. 

*Hangi sınıf olduğuna seçebilmek, 

*Öğrencilerin ve öğretmenlerin hangi şubede dersi olabildiğine bakabilmek. 

 

Bu çerçevede ; gereklilik analizinden de yola çıkılarak yapılan çalışma sonucunda aşağıdaki varlıkların planlanması gerekli bulunmuş, planlama da buna yönelik olarak yapılmıştır. Buna göre Varlık Kümelerinin aşağıdaki maddelerden oluşması planlanmıştır. 

**Sınıf Varlık Kümesi, 

**Öğretmen Varlık Kümesi, 

**Gün Varlık Kümesi,    

**Ders Varlık Kümesi. 

**3-) MANTIKSAL TASARIM** 

  Öğrenci İşleri veri tabanı tasarımında varlık kümeleri arasındaki ilişkilerin tasarlanmasından sonra mantıksal tasarım aşamasına geçilmiştir. Bu aşamada Birincil anahtar ve Yabancı anahtarlar eklenerek tablolar oluşturulur.
  Veri Tabanı Diyagramı gösterildiği gibidir.
  

  ![image](https://github.com/user-attachments/assets/49b36829-ff29-4f2f-82e4-6a0ab287fd87)





  
                          ***Proje Uygulama Kısmı***
  
  *1.1. Ders Programı Uygulaması Kullanıcı Giriş Ekranı* 

Öncelikli olarak MSSQL veri tabanı ile bağlantı kurulması sağlanmıştır. Giriş ekranında sorumlu olan öğretmenlerin ya da müdürün giriş yapması hedeflenmiştir. Kullanıcı adı ve şifre doğru girildiğinde Ana sayfa ekranı gelmektedir. Tablo 1 de kullanıcı giriş ekranı gösterilmiştir. 
  
  **Tablo 1: Kullanıcı Giriş Ekranı**

  
![image](https://github.com/user-attachments/assets/83616a72-64ce-45d5-a090-1526e5d276b5)
  
  

*1.2. Ana Sayfa* 

Giriş yapıldığında ana ekran gelmektedir. Tablo 2’de Ana Sayfa tablosu gösterildiği gibidir. Bu ekran dan şunlara erişebilmekteyiz; 

*Ders Programı, 
*Yeni Öğretmen Ekleme, 
*Öğretmen Güncelleştirme, 
*Öğretmen Silme, 
*Öğretmenler, 
*Derslikler, 
*Derslik Ekleme. 
 **Tablo 2: Ana sayfa**
 

 ![image](https://github.com/user-attachments/assets/d6fe839b-4b63-424f-9310-6b8e4dd431a7)

*1.3. Yeni Öğretmen Ekleme* 

Öğretmen ekleme sayfasında öğretmen adı, soyadı, TC, eposta, telefon, doğum tarihini girerek yeni bir öğretmen ekliyoruz. Tablo 3’te Öğretmen Ekle formumuz gösterildiği gibidir. 

**Tablo 3: Yeni Öğretmen Ekleme**


 ![image](https://github.com/user-attachments/assets/9ec9b597-953c-423a-8fc9-410153fe7e99)


*1.4.Sınıf Ekleme* 

Sınıf ekleme sayfasında Sınıf Adı, Sınıf Mevcudu bilgilerini girerek yeni bir sınıf ekliyoruz. Tablo 4’de Sınıf Ekleme formumuz gösterildiği gibidir. 

**Tablo 4: Sınıf Ekleme**


![image](https://github.com/user-attachments/assets/2308c279-27eb-4161-a2a3-203ce9f8b9b0)


*1.5.Öğretmen Güncelleme* 

Öğretmen güncelleme sayfasında ID ile Öğretmen bilgilerinin gelmesini sağlıyoruz. Değişmesi gerekenleri değiştirerek Öğretmen bilgilerini güncelliyoruz. Tablo 5’te Öğretmen Güncele formu gösterildiği gibidir. 

**Tablo 5: Öğretmen Güncelle**


![image](https://github.com/user-attachments/assets/866f59a6-e450-4452-ae4f-5cca80382811)


 *.6. Öğretmen Silme* 

Öğretmen silme sayfasında ID ile Öğretmen bilgilerinin gelmesini sağlıyoruz. Silinmesi gereken Öğretmen ID seçerek bilgilerini siliyoruz. Tablo 6 ‘da gösterildiği gibidir.  


**Tablo 6: Öğretmen Silme**

                            
![image](https://github.com/user-attachments/assets/6356b48f-bbed-40ed-bfce-2a9fa7820a4e)


*1.7.Sınıf Ara ve Seç* 

Ana sayfada combobox tan arama kriteri seçerek aranacak öğeyi yazıp sınıf ara butonuna basıyoruz ve veriler ana ekranda listeleniyor. Ek olarak yanında bulunan sınıf combobox ’tan istediğiniz sınıf verisini seçebilirsiniz. Tablo 7’de Sınıf Ara formu gösterildiği gibidir.  


**Tablo 7: Sınıf Ara**


![image](https://github.com/user-attachments/assets/e76723c8-dda1-48fd-bca7-ad796ad665a0)


*1.8.Öğretmen Ara ve Seç* 

Ana sayfada combobox tan arama kriteri seçerek aranacak öğeyi yazıp öğretmenler butonuna basıyoruz ve veriler ana ekranda datagridde listeleniyor. Ek olarak yanında bulunan öğretmen combobox ’tan istediğiniz öğretmen verisini seçebilirsiniz Tablo 8’de gösterildiği gibidir.  

 

**Tablo 8: Öğretmen Ara ve Seç**

![image](https://github.com/user-attachments/assets/b40b49e1-ac48-4dd9-b339-b87ae94db476)


*1.9. Gün Seçme* 

Ana sayfa da bulunan Gün labelın yanında bulunan gün combobox ’tan istediğiniz gün verisini seçebilirsiniz Tablo 9’da gösterildiği gibidir.  

 
**Tablo 9: Gün Seçme**


![image](https://github.com/user-attachments/assets/e4a87729-ee0f-46a4-83fe-26cd3d59bb3b)

*1.10.Saat Seçme* 

Ana sayfa da bulunan Saat labelın yanında bulunan saat combobox ’tan istediğiniz saat verisini seçebilirsiniz Tablo 10’da gösterildiği gibidir.  

 

**Tablo 10: Saat Seçme**


![image](https://github.com/user-attachments/assets/5b23024a-c1c1-4625-b1ed-e3d178cd5738)


*1.11. Sınıf Silme* 

Sınıf silme sayfasın da   Sınıf_ID, Sınıf Adı, Sınıf Mevcudu bilgilerini   SINIF_ID Comboboxtan seçerek, seçtiğiniz sınıf siliyoruz. Tablo 11’de Sınıf Silme formumuz gösterildiği gibidir. 

 

**Tablo 11: Sınıf Silme**

![image](https://github.com/user-attachments/assets/00a86cb3-b4e4-422c-89e8-3ced256aede7)


*1.12. Sınıf Güncelleme* 

Sınıf silme sayfasın da   Sınıf_ID, Sınıf Adı, Sınıf Mevcudu bilgilerini   SINIF_ID Comboboxtan seçerek, seçtiğiniz sınıfın değişmesini istediğiniz verileri değiştirip güncelleyebilirsiniz. Tablo 12’de Sınıf Güncelleme formumuz gösterildiği gibidir. 

 

**Tablo 12: Sınıf Güncelleme**


![image](https://github.com/user-attachments/assets/9567035a-e81b-44bd-95d2-b3f63c057cb4)


*1.13. Ders Programı İçin Comboboxtaki Verileri Yazdırma* 

Ana sayfadaki Sınıf ıd, öğretmen ıd, gün ıd ve saat ıd Comboboxta seçip verileri veri tabanına ekleyip gridte getirip yazdırma formudur. Tablo 13 ‘te gösterildiği gibidir 

 

**Tablo 13: Ders Programı İçin Comboboxtaki Verileri Yazdırma**


![image](https://github.com/user-attachments/assets/09778fe2-0571-4319-9005-0da5a7f50a6e)








