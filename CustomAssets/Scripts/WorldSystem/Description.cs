﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Description : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        switch (this.gameObject.tag)
        {
            case "Food":
                print("еда");
                this.gameObject.AddComponent<Food>();
                break;
            case "Weapon":
                print("оружие");
                break;
            case "Shild":
                print("щит");
                break;
            case "Staff":
                print("посох");
                break;
            case "Artifact":
                print("артефакт");
                break;
        }
    }
}
/*Альтруистичный, адекватный, активный.
Бережливый, бесстрашный, благородный, благоразумный.
Вежливый, великодушный, веселый, внимательный, волевой, высоконравственный, воспитанный.
Галантный, гармоничный, гуманный.
Дальновидный, деликатный, деловой, дипломатичный, джентльмен, добродушный, добрый, добросовестный, дружелюбный, дисциплинированный.
Естественный.
Жизнерадостный, женственный, жизнелюбивый.
Заботливый, запасливый, зрелый.
Искренний, инициативный, интеллигентный, изобретательный, исполнительный.
Коммуникабельный, компетентный, компанейский, корректный, коллективный, культурный, креативный, красноречивый.
Ласковый, легкий, лидер, любознательный.
Миролюбивый, мечтательный, мужественный, мудрый.
Наблюдательный, надежный, находчивый, нежный, независимый.Черты характера человека
Обаятельный, общительный, образованный, объективный, одаренный, опрятный, опытный, осторожный, отзывчивый, ответственный.
Позитивный, порядочный, понимающий, приветливый, практичный.
Радушный, решительный, романтичный.
Самокритичный, самостоятельный, скромный, совестливый, сообразительный.
Творческий, тактичный, терпеливый, трудолюбивый.
Уважительный, улыбчивый, усидчивый, упорный, учтивый, уравновешенный.
Харизматичный, хозяйственный, храбрый.
Целеустремленный, целомудренный.
Честный, чуткий, чистосердечный.
Шутливый, щедрый.
Экономный, эмпатичный, энтузиаст, энергичный, эрудированный.
- Агрессивность, алчность, апатичность.
Безволие, бездуховность, безжалостность, бесчувствие, безответственность, брезгливость, бесстыдность.
Ветреность, властолюбие, вульгарность, высокомерие.
Гневливость, гордыня, грубость.
Двуличность.
Ехидность.
Жадность, жестокость.
Завистливость, задиристость, злопамятность, злость.
Избалованность, инертность, инфантильность, истеричность.
Капризность, коварство, конфликтность.
Лживость, лицемерие, льстивость.
Малодушие, меркантильность, мнительность, мстительность, мрачность.
Наглость, надменность, невежество, нервозность, неопрятность, неуравновешенность.
Обидчивость, ограниченность.Качества характера человека
Плаксивость, поверхностность, подозрительность, прижимистость.
Равнодушие, развратность, раздражительность, ревнивость.
Самовлюбленность, сварливость, склочность.
Тревожность, тщеславие.
Хвастливость.
Черствость.
Эгоистичность.
Язвительность.*/
