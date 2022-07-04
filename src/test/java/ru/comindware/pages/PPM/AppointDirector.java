package ru.comindware.pages.PPM;

import com.codeborne.selenide.SelenideElement;
import io.qameta.allure.Step;
import ru.comindware.PlatformComponents;

import static com.codeborne.selenide.Condition.text;
import static com.codeborne.selenide.Selenide.$;

public class AppointDirector {
    PlatformComponents platformComponents = new PlatformComponents();
    SelenideElement notificationContainer = platformComponents.notificationContainer(),
            addNewRecordToCollection = platformComponents.addNewRecordToCollection(3),
            collectionField1 = platformComponents.collectionField(3),
            dropDown = platformComponents.dropDown(4),
            firstListCheckBox = platformComponents.firstListCheckBox(),
            completeTask = $("[title=\"Завершить\"]");

    @Step("Добавить руководителя в коллекцию")
    public AppointDirector FillFormField(String fioRukovoditel) {
        addNewRecordToCollection.click();
        collectionField1.click();
        dropDown.setValue(fioRukovoditel);
        firstListCheckBox.click();
        return this;
    }
    @Step("Завершить задачу")
    public AppointDirector CompleteTask() {
        completeTask.click();
        return this;
    }

    @Step("Задача завершена")
    public AppointDirector OperationComplete() {
        notificationContainer.shouldHave(text("Операция выполнена"));
        return this;
    }
}
