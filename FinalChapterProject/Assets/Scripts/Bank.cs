using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bank : MonoBehaviour
{
    public Text bankDepositText;
    public Text checkMoney;
    public InputField amountMoneyText;
    public int amountMoney;
    public int moneyTest; //Ex Money in status

    private int bankdeposit;

    // Start is called before the first frame update
    void Start()
    {
        bankdeposit = 0;
        bankDepositText.text = bankdeposit + " B ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Deposit()
    {
        if(amountMoneyText.text != "")
        {
            amountMoney = System.Convert.ToInt32(amountMoneyText.text);
            if (amountMoney != 0)
            {
                if (amountMoney <= moneyTest)
                {
                    moneyTest = moneyTest - amountMoney;
                    bankdeposit = bankdeposit + amountMoney;
                    UpdateBankDepositText();
                    checkMoney.text = "ฝากเงินเสร็จสิ้น";
                    checkMoney.color = Color.green;
                    amountMoneyText.text = "";  ///Note: add Energy
                }
                else
                {
                    checkMoney.text = " ท่านไม่มีเงินพอที่จะฝากตามจำนวนนี้ ";
                    checkMoney.color = Color.red;
                }
            }
            else
            {
                checkMoney.text = " โปรดใส่จำนวนเงินที่ต้องการฝากให้ถูกต้อง ";
                checkMoney.color = Color.red;
            }
        }
        else
        {
            checkMoney.text = " โปรดใส่จำนวนเงินที่ต้องการฝาก ";
            checkMoney.color = Color.red;
        }
    }

    public void AllDeposit()
    {
        if(moneyTest != 0)
        {
            bankdeposit = bankdeposit + moneyTest;
            moneyTest = 0;
            UpdateBankDepositText();
            checkMoney.text = "ฝากเงินเสร็จสิ้น";
            checkMoney.color = Color.green;   ///Note: add Energy
        }
        else
        {
            checkMoney.text = " ท่านไม่มีเงินพอที่จะฝากเลย ";
            checkMoney.color = Color.red;
        }
    }

    public void WithDraw()
    {
        if (amountMoneyText.text != "")
        {
            amountMoney = System.Convert.ToInt32(amountMoneyText.text);
            if (amountMoney != 0)
            {
                if (amountMoney <= bankdeposit)
                {
                    moneyTest = moneyTest + amountMoney;
                    bankdeposit = bankdeposit - amountMoney;
                    UpdateBankDepositText();
                    checkMoney.text = "ถอนเงินเสร็จสิ้น";
                    checkMoney.color = Color.green;
                    amountMoneyText.text = "";   ///Note: add Energy
                }
                else
                {
                    checkMoney.text = " ท่านไม่มีเงินฝากพอที่จะถอนตามจำนวนนี้ ";
                    checkMoney.color = Color.red;
                }
            }
            else
            {
                checkMoney.text = " โปรดใส่จำนวนเงินที่ต้องการถอนให้ถูกต้อง ";
                checkMoney.color = Color.red;
            }
        }
        else
        {
            checkMoney.text = " โปรดใส่จำนวนเงินที่ต้องการถอน ";
            checkMoney.color = Color.red;
        }
    }

    public void AllWithDraw()
    {
        if (bankdeposit != 0)
        {
            moneyTest = moneyTest + bankdeposit;
            bankdeposit = 0;
            UpdateBankDepositText();
            checkMoney.text = "ถอนเงินเสร็จสิ้น";
            checkMoney.color = Color.green;   ///Note: add Energy
        }
        else
        {
            checkMoney.text = " ท่านไม่มีเงินฝากพอที่จะถอนเลย ";
            checkMoney.color = Color.red;
        }
    }

    public void BankInterest()
    {
        bankdeposit += (bankdeposit * 1 ) / 100;
        UpdateBankDepositText();
    }

    private void UpdateBankDepositText()
    {
        bankDepositText.text = bankdeposit + " B ";
    }
}
