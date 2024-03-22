
```mermaid
    form1 <|-- Control
    form1 <|-- box
    form1 <|-- csv
classDiagram
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
