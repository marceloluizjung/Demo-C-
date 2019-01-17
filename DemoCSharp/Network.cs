using System;

public class Network
{

    private int number_elements;
    private int number_elements_insert;

    //Matriz 
    private int[,] matriz;


    public int Number_Elements
    {
        get
        {
            return number_elements;
        }
        set
        {
            if (value >= 0)
            {
                number_elements = value;
                matriz = new int[value, value];
            }
            else
            {
                throw new System.ArgumentException("Parameter invalid");
            }
        }
    }


    public Network(int number_elements)
    {
        Number_Elements = number_elements;

    }

    public Network()
    {
    }

    public void InsertElements(int element)
    {
        if (this.number_elements_insert != this.number_elements && element > 0 && !this.CheckExistence(element))
        {
            this.matriz[this.number_elements_insert, 0] = element;
            this.number_elements_insert++;
        }
        else
        {
            throw new System.ArgumentException("Element invalid");
        }
    }

    private Boolean CheckExistence(int number)
    {

        for (int linha = 0; linha < this.number_elements; linha++)
        {

            if (this.matriz[linha, 0] == number)
            {
                return true;
            }

        }
        return false;

    }

    private void SearchInsert(int number1, int number2)
    {

        for (int linha = 0; linha < this.number_elements; linha++)
        {

            if (this.matriz[linha, 0] == number1)
            {

                for (int coluna = 0; coluna < this.number_elements; coluna++)
                {
                    if (this.matriz[linha, coluna] == 0)
                    {
                        this.matriz[linha, coluna] = number2;
                        break;
                    }

                }
                break;
            }

        }
    }

    public void Connect(int number1, int number2)
    {

        if (this.CheckExistence(number1) && this.CheckExistence(number2) && !this.Query(number1, number2) && number1 > 0 && number2 > 0 && number1 != number2)
        {
            this.SearchInsert(number1, number2);
            this.SearchInsert(number2, number1);
        }
        else
        {
            throw new System.ArgumentException("Connection refused");
        }

    }

    public Boolean Query(int number1, int number2)
    {
        if (this.CheckExistence(number1) && this.CheckExistence(number2) && number1 > 0 && number2 > 0 && number1 != number2)
        {
            for (int linha = 0; linha < this.number_elements; linha++)
            {

                if (this.matriz[linha, 0] == number1)
                {

                    for (int coluna = 0; coluna < this.number_elements; coluna++)
                    {
                        if (this.matriz[linha, coluna] == number2)
                        {
                            return true;
                        }
                    }
                    break;
                }
            }
        }
        else
        {
            throw new System.ArgumentException("Connection refused");
        }
        return false;
    }

}
