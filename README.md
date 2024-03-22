
1.ความเป็นมาของโปรแกรม  
 เนื่องจากเห็นระบบของตู้เซเว่น จึงอยากทำตู้กล่องสุ่มที่คล้ายๆระบบของเซเว่นเพื่อจำหน่ายในห้างสรรพสินค้า ในจังหวัดต่างๆ

2.วัตถุประสงค์ของโปรแกรม
ทำโปรแกรมตู้กล่องสุ่ม

3.โครงสร้างของโปรแกรม (Class diagram) ของโปรแกรม ใช้ Mermaid ในการเขียน ตัวอย่าง การเขียน Classdiagram ใน Markdown

```mermaid
classDiagram
   Form1 <|-- Control
    Form1 <|-- Box
    Form1 <|-- CSV
    class Form1 {
        -Control controller
        -Box box
        -CSV csv
        -int button3Numberofproducts3
        -int button1Numberofproducts1
        +Form1()
        +button2_Click(sender: object, e: EventArgs): void
        +button3_Click(sender: object, e: EventArgs): void
        +button4_Click(sender: object, e: EventArgs): void
        +button5_Click(sender: object, e: EventArgs): void
        +button6_Click(sender: object, e: EventArgs): void
        +button8_Click(sender: object, e: EventArgs): void
        +summit_Click(sender: object, e: EventArgs): void
    }
    class Control {
        -int product1
        -int product2
        -int product3
        -int product4
        -int product5
        +mybox3(): bool
    }
    class Box {
        -Image box1
        -Image box2
        -Image box3
        -Image box4
        -Image box5
        -int sum
        -int products
    }
    class CSV {
        +FileCsv(lists: string, products: int, sum: int): bool
    }
    ```
```
4.ชื่อของผู้พัฒนาโปรแกรม  นางสาวจุฑาทิพย์ ภูบุญลอด รหัสนักศึกษา 663450036-3
