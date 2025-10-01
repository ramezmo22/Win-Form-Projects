#pragma once
#include <iostream>
#include "clsScreen.h"
#include "clsCurrency.h"
#include <iomanip>

class clsCarrencyListScreen:protected clsScreen
{
private:
    static void PrintCurrencyRecordLine(clsCurrency Currency)
    {

        cout << setw(8) << left << "" << "| " << setw(30) << left << Currency.Country();
        cout << "| " << setw(8) << left << Currency.CurrencyCode();
        cout << "| " << setw(45) << left << Currency.CurrencyName();
        cout << "| " << setw(10) << left << Currency.Rate();

    }
public:
    static void ShowCurrenciesListScreen()
    {

        vector<clsCurrency> vCurrencys = clsCurrency::GetCurrenciesList();
        clsScreen::_DrawScreenHeader("\tCarrency List Screen", "\t    (" + to_string(vCurrencys.size()) + ") Currency.");
        cout << setw(8) << left << "" << "\n\t_______________________________________________________";
        cout << "_______________________________________________\n" << endl;

        cout << setw(8) << left << "" << "| " << left << setw(30) << "Country";
        cout << "| " << left << setw(8) << "Code";
        cout << "| " << left << setw(45) << "Name";
        cout << "| " << left << setw(10) << "Rate/(1$)";
        cout << setw(8) << left << "" << "\n\t_______________________________________________________";
        cout << "_______________________________________________\n" << endl;
        if (vCurrencys.size() == 0)
        {
            cout << "\nThere is no currencies To Show !";
        }
        else
        {
            for (clsCurrency Currency : vCurrencys)
            {

                PrintCurrencyRecordLine(Currency);
                cout << endl;
            }
        }
        cout << setw(8) << left << "" << "\n\t_______________________________________________________";
        cout << "_______________________________________________\n" << endl;






    }

};

