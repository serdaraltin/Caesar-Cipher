# Sezar-Sifreleme (Caesar Cipher)
**CSharp Programlama Dilinde Sezar Sifreleme**

------------



##### Tarihte bilinen ilk şifreleme algoritması olan Sezar Şifreleme kullanılarak hazırlanan bir CSharp uygulamasıdır.

- [YOUTUBE](https://www.youtube.com/channel/UCltJlvbcFATfBm0qHttpZNg?view_as=subscriber "YOUTUBE") kanalında verilen eğitime katkıda bulunması amacıyla hazırlanmıştır.
- **VISUAL STUDIO 2015** editörü kullanılarak hazırlanan uygulama görsel bir arayüze sahiptir.


------------
<br>

#### Vikipedi, özgür ansiklopedi

Tarihin ilk kriptolojik fikirleri İngilizce'de transposition and substitution cipher adını taşır, yani yer değiştirme ve harf değiştirme şifrelemesi. Bu yöntemlerden ilki bir yazıdaki harflerin yerlerini değiştirerek, ikincisi ise harfleri başka harflerle değiştirerek elde edilir. Bu şifrelemeyi kullanan belki de en ünlü teknik Sezar Şifresi'dir: Bu şifrede, her harf o harften birkaç sonraki harf kullanılarak yazılır. Örneğin, 3 harf atlamalı Sezar Şifresi'nde **"deneme"** yerine **"ghqhph"** yazılır.

Öte yandan, **Sezar Şifresi**(Cevrimsel alfabe) kırmak görece kolay olmaktadır: Bir filolog, bir dilde en çok geçen harfleri bulabilir. O harfler ile mesajda en sık geçen harfleri karşılaştırarak hangi harfin hangi harf ile değiştirildiğini bulabilir. Bu adımların ardından, mesaj çözülmüş olur. Sezar Şifresi Hakkında:

**Kaba kuvvet** (brute-force) saldırısıyla çok kolay çözülür. ÇünküŞifreleme/Şifre çözme yöntemi gizli değildir.
Sadece **25** (Latin alfabesi harf sayısı) farklı deneme yeterlidir. (Anahtar uzayı 25 elemanlıdır.)
**Düz metin** (plaintext) ve formatı gizli değildir.
Harf değiştirme şifrelemelerinde toplam 26! farklı şifre tablosu vardır.


------------
### [Meyta - Kriptoloji 2 - Sezar Şifreleme](https://www.youtube.com/watch?v=nZwcoATMVdo "Kriptoloji 2 - Sezar Şifreleme")
![Meyta - Kriptoloji 2 - Sezar Şifreleme](https://github.com/serdaraltin/Caesar-Cipher/blob/master/Sezar%20Sifreleme/bin/Debug/On%20Izleme.jpg)

------------

**Tasarım - Form1.Designer.cs**

![Form1](https://github.com/serdaraltin/Caesar-Cipher/blob/master/Sezar%20Sifreleme/obj/Debug/ScreenShot.PNG)

------------



**Kod - Form1.cs**

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sezar_Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string acik_mesaj = tx_acikmesaj.Text;
            string sifreli_mesaj = "";
            List<char> karekter = acik_mesaj.ToCharArray().ToList();

            for ( int i=0; i < karekter.Count(); i++)
            {
                sifreli_mesaj = sifreli_mesaj + (char)(karekter[i] + Convert.ToInt32(tx_anahtar.Text));
            }

            tx_sifrelimesaj.Text = sifreli_mesaj;

        }
    }
}
```

**Powered By DeadSound**
