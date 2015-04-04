import com.itextpdf.text.*;
import com.itextpdf.text.Document;
import com.itextpdf.text.Element;
import com.itextpdf.text.pdf.*;

import javax.swing.*;
import java.io.FileOutputStream;

public class FirstPdf {

    public static void main(String[] args) {

        //choose destination folder for the output file
        JFileChooser f = new JFileChooser();
        f.setFileSelectionMode(JFileChooser.DIRECTORIES_ONLY);
        f.showSaveDialog(null);

        //System.out.println(f.getCurrentDirectory());
        
        
        String destinationFolder = f.getSelectedFile().toString();
        
        //check if OS is Windows, Linux or Mac and change file path
        String operatingSystem = System.getProperty("os.name").toLowerCase();
        char c = operatingSystem.charAt(0);
        String FILE = "";
        if (c == 'w') {
        	FILE =  destinationFolder + "\\FirstPdf.pdf";
        } else {
        	FILE =  destinationFolder + "/FirstPdf.pdf";
        }
        


        try {
            Document document = new Document();
            PdfWriter.getInstance(document, new FileOutputStream(FILE));

            //create new font for the unicode symbols
            //font is in fonts folder
            BaseFont baseFont = BaseFont.createFont("fonts/arialuni.ttf", BaseFont.IDENTITY_H, true);
            Font fontRed = new Font(baseFont, 18, Font.BOLD, BaseColor.RED);
            Font fontBlack = new Font(baseFont, 18, Font.BOLD, BaseColor.BLACK);
            document.open();

            //create table with 4 columns
            PdfPTable table = new PdfPTable(4);

            //create table header row
            PdfPCell c1 = new PdfPCell(new Phrase("Hearts"));
            c1.setBorder(Rectangle.NO_BORDER);
            c1.setHorizontalAlignment(Element.ALIGN_CENTER);
            table.addCell(c1);

            c1 = new PdfPCell(new Phrase("Diamonds"));
            c1.setBorder(Rectangle.NO_BORDER);
            c1.setHorizontalAlignment(Element.ALIGN_CENTER);
            table.addCell(c1);

            c1 = new PdfPCell(new Phrase("Clubs"));
            c1.setBorder(Rectangle.NO_BORDER);
            c1.setHorizontalAlignment(Element.ALIGN_CENTER);
            table.addCell(c1);

            c1 = new PdfPCell(new Phrase("Spades"));
            c1.setBorder(Rectangle.NO_BORDER);
            c1.setHorizontalAlignment(Element.ALIGN_CENTER);
            table.addCell(c1);
            table.setHeaderRows(1);


            //cards symbols and suites
            String[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            String[] symbols = {"\u2665", "\u2666", "\u2663", "\u2660"};

            for (int i = 0; i < 13; i++) {
                for (int j = 0; j < 4; j++) {
                    //fill cards, first two cards - red, other two - black
                    if ( j < 2) {
                        c1 = new PdfPCell(new Phrase(cards[i] + symbols[j], fontRed));
                    } else {
                        c1 = new PdfPCell(new Phrase(cards[i] + symbols[j], fontBlack));
                    }
                    c1.setVerticalAlignment(Element.ALIGN_MIDDLE);
                    c1.setHorizontalAlignment(Element.ALIGN_CENTER);
                    c1.setBackgroundColor(BaseColor.LIGHT_GRAY);
                    c1.setBorderColor(BaseColor.WHITE);
                    c1.setFixedHeight(150);

                    c1.setBorderWidth(20);
                    table.addCell(c1);
                    table.setHorizontalAlignment(Element.ALIGN_CENTER);
                }
            }

            document.add(table);

            document.close();

        } catch (Exception e) {
            e.printStackTrace();
        }

        System.out.println("You can find your file at: " + FILE);
    }
}
