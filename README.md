# Observer-Memento-State

------------------------------------------------------- OBSERVER -------------------------------------------------------
![observer drawio](https://github.com/GIGI-bit/Observer-Memento-State/assets/64860005/484c6241-d8ac-4980-9631-e610582a201b)

Bu nümunədə Observer behavioral design pattern-i YouTube-un Creator-Viewer arasındakı əlaqəyə əsaslanaraq izah edilmişdir. 
Yuxarıdakı şəkildə izləyicilər Subscriber ve Viewer olmaqla ikiyə bölünmüşdür bunun səbəbi Youtube-da izləyicilərin abonə olmadanda video izləyə bilmələridir. Amma özləri yoxlamadığı müddətcə yeni videolardan xəbərdar ola bilmezler. Bu səbəbdən Viewer class-ı VideoViewer interface-inden implement olunmayıb.
Elave olaraq, Youtube ve Youtuber bir-birlerinin obyect-lerini saxladıqları üçün aralarında Assosation(two way), Video və Youtuber arasında yenə Assosation(two way), Youtuber və VideoViewer arasında Assosation(one way)  mövcuddur.

------------------------------------------------------- MEMENTO --------------------------------------------------------
![Memento drawio](https://github.com/GIGI-bit/Observer-Memento-State/assets/64860005/57560d3d-27cd-4758-a983-21d6b085c7b4)

Bu nümunəmizdə bir Foto Editor-un class diagramıni görürük. Editor-da müəyyən işləri icra edən object-lərin classlarını eyni ad altına toplamaq üçün onları IOperation interface-indən implement edirik. PhotoMemento class-ı Editor class-ını kopyalaya bilsin deyə onunla eyni field və member-lərə sahib olmalıdır. MementoSaver Class-ı isə özündə PhotoMemento collection-u saxlayır.

------------------------------------------------------- STATE ----------------------------------------------------------
![State drawio](https://github.com/GIGI-bit/Observer-Memento-State/assets/64860005/782f44f5-a000-4bcf-b2fd-1274b648dce9)

Computer class-ı ilə State class-ı arasinda Assosation(two way) mövcuddur. State class-ının constructor-unda Computer class-ının object-i istifade olunduğu üçün State Computer-dən asılıdır.
