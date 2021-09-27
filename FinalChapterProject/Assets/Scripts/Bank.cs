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
                    checkMoney.text = "�ҡ�Թ�������";
                    checkMoney.color = Color.green;
                    amountMoneyText.text = "";  ///Note: add Energy
                }
                else
                {
                    checkMoney.text = " ��ҹ������Թ�ͷ��нҡ����ӹǹ��� ";
                    checkMoney.color = Color.red;
                }
            }
            else
            {
                checkMoney.text = " �ô���ӹǹ�Թ����ͧ��ýҡ���١��ͧ ";
                checkMoney.color = Color.red;
            }
        }
        else
        {
            checkMoney.text = " �ô���ӹǹ�Թ����ͧ��ýҡ ";
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
            checkMoney.text = "�ҡ�Թ�������";
            checkMoney.color = Color.green;   ///Note: add Energy
        }
        else
        {
            checkMoney.text = " ��ҹ������Թ�ͷ��нҡ��� ";
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
                    checkMoney.text = "�͹�Թ�������";
                    checkMoney.color = Color.green;
                    amountMoneyText.text = "";   ///Note: add Energy
                }
                else
                {
                    checkMoney.text = " ��ҹ������Թ�ҡ�ͷ��ж͹����ӹǹ��� ";
                    checkMoney.color = Color.red;
                }
            }
            else
            {
                checkMoney.text = " �ô���ӹǹ�Թ����ͧ��ö͹���١��ͧ ";
                checkMoney.color = Color.red;
            }
        }
        else
        {
            checkMoney.text = " �ô���ӹǹ�Թ����ͧ��ö͹ ";
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
            checkMoney.text = "�͹�Թ�������";
            checkMoney.color = Color.green;   ///Note: add Energy
        }
        else
        {
            checkMoney.text = " ��ҹ������Թ�ҡ�ͷ��ж͹��� ";
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
