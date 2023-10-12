// GENERATED AUTOMATICALLY FROM 'Assets/InputControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""4724fe37-9e89-45a8-b23e-91d26ae26504"",
            ""actions"": [
                {
                    ""name"": ""StickInputXY"",
                    ""type"": ""Value"",
                    ""id"": ""58fe4ab5-736f-4229-afdc-3222585e6ae6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ThrottleUp"",
                    ""type"": ""Button"",
                    ""id"": ""b7007cd8-51d3-44f1-949a-19abcfe9885d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""ThrottleDown"",
                    ""type"": ""Button"",
                    ""id"": ""2c54d9c5-5fc0-4825-ad29-c24d50420cfc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Yaw"",
                    ""type"": ""Value"",
                    ""id"": ""eba5de12-4312-4461-93a0-a94e07cef182"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""e14abbc6-30d5-416c-9546-ed3090d3a9e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aerobrake"",
                    ""type"": ""Button"",
                    ""id"": ""0ee3e780-7c4b-4a93-809d-c4762a315360"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeCam"",
                    ""type"": ""Button"",
                    ""id"": ""6f9f9fe6-6192-4aeb-9eae-b20be25a0881"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraRotation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3554504f-5390-469f-b5c8-5cb253901d67"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GearChange"",
                    ""type"": ""Button"",
                    ""id"": ""49169bfc-3109-415a-9759-d9453726801e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Throttle"",
                    ""type"": ""Value"",
                    ""id"": ""ff0de257-e881-4d1c-baab-79bc5b05d856"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ec737945-7638-4459-9528-654074de8a8e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertY=false)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""StickInputXY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""871c1b6a-c5d8-46a9-9e98-48cd0cfd939d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertY=false)"",
                    ""groups"": """",
                    ""action"": ""StickInputXY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8ba8a564-40f2-44e3-b462-1c7b9606a7a2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StickInputXY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b2c7931d-1a7e-4615-bc5b-3fd48cc186b4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StickInputXY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7112074b-e611-421c-908b-034ce7d56f2a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StickInputXY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c97c15b4-f0f9-4bd2-bc74-bef542435b90"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StickInputXY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""c23f7a7c-fce8-42f6-9a2d-0d3de9d0acac"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertY=false)"",
                    ""groups"": """",
                    ""action"": ""StickInputXY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b044720d-ffbf-4096-a3a1-fb5d647146f4"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StickInputXY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fe73893a-ab5e-4f49-8b82-42ba4ab2742e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StickInputXY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""42828310-61f1-48b0-bb52-8b338814501b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StickInputXY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8ca64272-5efc-44d4-9dc2-eb2e8b803df3"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StickInputXY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3cd41926-649f-4384-8db2-156787f7f54f"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertY=false)"",
                    ""groups"": ""Joystick"",
                    ""action"": ""StickInputXY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a66c176-3fa0-4208-a88f-01ed4406d023"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ThrottleUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0b0c061-3fbd-41b0-a820-4aa86b928e11"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ThrottleUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71c3ec08-d941-4505-a093-635daa56ef18"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ThrottleUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa96b419-83bb-4910-9587-37b5667cd911"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""ThrottleUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""045fd9d9-84b3-4655-942e-e67b6433a5d3"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ThrottleDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdeca451-2ac0-4454-9270-4635a6e33abe"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ThrottleDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcbfe8de-2d13-4039-b7a6-d5247f107420"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ThrottleDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ddaca160-f191-47a2-bea7-1e935d38b006"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/button7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""ThrottleDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Triggers 1D Axis"",
                    ""id"": ""79dc6d7c-5a07-4dbb-a86a-63aa1c78a4da"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f9dfd5d5-e4f3-4430-a2e6-50174f06cc6b"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""86280162-5ae0-4518-9378-6459b17aa5c4"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Stick 1D Axis"",
                    ""id"": ""9d63fc9e-0b2c-46e8-bf4a-35f0847dd5bc"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9b00d023-dca6-432c-af5b-38d25d9198fa"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""595d2980-82b0-46f1-9b50-75594060ecdd"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""12f72423-6a13-4c28-86af-f536c2f71278"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a1f3e6fd-1199-42ff-8f92-249186ef8940"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5357aca1-28f2-4a9f-80d9-48a5b7802d41"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7e89f7f8-6fff-42d1-9a49-5e45757be8d6"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/slider"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6e72e19-087a-49ac-b0be-c405b90a3be3"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Gamepad Button With One Modifier"",
                    ""id"": ""f843802b-5aa7-4af7-ad93-9e14451e284f"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""15fa76a3-c777-41de-9079-61225010a21b"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""e8620942-560e-4555-aad3-a74fb7c9b17f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""66364e5f-b0ca-4363-8d56-c31fc2220271"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/button11"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Gamepad Button With One Modifier"",
                    ""id"": ""fe785d3c-694d-4bed-b450-cb4b2da4020d"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aerobrake"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""ab8ab353-4e06-4f2c-994b-62a2dac30a21"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Aerobrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""ff0a1066-d5ce-4c0b-9385-baea822dc0aa"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Aerobrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard Button With One Modifier"",
                    ""id"": ""04331913-8fd7-4621-a62c-26338c3c0810"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aerobrake"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""5025e4a9-e423-42c0-b5a7-265a9571c6eb"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Aerobrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""9f94a4bb-ae69-4cc9-b6c4-6172cdaec6d6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Aerobrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""94897eb3-cbf4-4563-b2e6-9b4b6d4700f9"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Aerobrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29e018c7-d8a4-4a94-8d0f-e61401657d00"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ChangeCam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fdb83373-3458-42df-950a-60fb0d217268"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeCam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d561408-204e-4bdd-bc3a-a96088d3ff26"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""ChangeCam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44009e58-9b92-4f95-aa36-a67286288b86"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6fa72387-a2d6-47c8-ab87-eaebb7c3c74e"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""GearChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85250d5e-7758-43a8-9a35-83971b1396f5"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GearChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf3ea098-ca76-42d8-9147-4bf717a1ccff"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/button6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""GearChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70a7cd13-a912-495c-9ec9-ff7995dd82b1"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""GearChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b081b60-6412-42ef-a354-d8227ede0b42"",
                    ""path"": ""<HID::Thrustmaster T.Flight Hotas X>/z"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=100),Normalize(max=1,zero=-100),Invert,Clamp(max=100)"",
                    ""groups"": ""Joystick"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<HID::Thrustmaster T.Flight Hotas X>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_StickInputXY = m_Player.FindAction("StickInputXY", throwIfNotFound: true);
        m_Player_ThrottleUp = m_Player.FindAction("ThrottleUp", throwIfNotFound: true);
        m_Player_ThrottleDown = m_Player.FindAction("ThrottleDown", throwIfNotFound: true);
        m_Player_Yaw = m_Player.FindAction("Yaw", throwIfNotFound: true);
        m_Player_Reset = m_Player.FindAction("Reset", throwIfNotFound: true);
        m_Player_Aerobrake = m_Player.FindAction("Aerobrake", throwIfNotFound: true);
        m_Player_ChangeCam = m_Player.FindAction("ChangeCam", throwIfNotFound: true);
        m_Player_CameraRotation = m_Player.FindAction("CameraRotation", throwIfNotFound: true);
        m_Player_GearChange = m_Player.FindAction("GearChange", throwIfNotFound: true);
        m_Player_Throttle = m_Player.FindAction("Throttle", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_StickInputXY;
    private readonly InputAction m_Player_ThrottleUp;
    private readonly InputAction m_Player_ThrottleDown;
    private readonly InputAction m_Player_Yaw;
    private readonly InputAction m_Player_Reset;
    private readonly InputAction m_Player_Aerobrake;
    private readonly InputAction m_Player_ChangeCam;
    private readonly InputAction m_Player_CameraRotation;
    private readonly InputAction m_Player_GearChange;
    private readonly InputAction m_Player_Throttle;
    public struct PlayerActions
    {
        private @InputControls m_Wrapper;
        public PlayerActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @StickInputXY => m_Wrapper.m_Player_StickInputXY;
        public InputAction @ThrottleUp => m_Wrapper.m_Player_ThrottleUp;
        public InputAction @ThrottleDown => m_Wrapper.m_Player_ThrottleDown;
        public InputAction @Yaw => m_Wrapper.m_Player_Yaw;
        public InputAction @Reset => m_Wrapper.m_Player_Reset;
        public InputAction @Aerobrake => m_Wrapper.m_Player_Aerobrake;
        public InputAction @ChangeCam => m_Wrapper.m_Player_ChangeCam;
        public InputAction @CameraRotation => m_Wrapper.m_Player_CameraRotation;
        public InputAction @GearChange => m_Wrapper.m_Player_GearChange;
        public InputAction @Throttle => m_Wrapper.m_Player_Throttle;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @StickInputXY.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStickInputXY;
                @StickInputXY.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStickInputXY;
                @StickInputXY.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStickInputXY;
                @ThrottleUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrottleUp;
                @ThrottleUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrottleUp;
                @ThrottleUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrottleUp;
                @ThrottleDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrottleDown;
                @ThrottleDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrottleDown;
                @ThrottleDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrottleDown;
                @Yaw.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYaw;
                @Yaw.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYaw;
                @Yaw.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYaw;
                @Reset.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReset;
                @Aerobrake.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAerobrake;
                @Aerobrake.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAerobrake;
                @Aerobrake.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAerobrake;
                @ChangeCam.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeCam;
                @ChangeCam.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeCam;
                @ChangeCam.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeCam;
                @CameraRotation.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraRotation;
                @GearChange.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGearChange;
                @GearChange.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGearChange;
                @GearChange.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGearChange;
                @Throttle.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrottle;
                @Throttle.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrottle;
                @Throttle.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrottle;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @StickInputXY.started += instance.OnStickInputXY;
                @StickInputXY.performed += instance.OnStickInputXY;
                @StickInputXY.canceled += instance.OnStickInputXY;
                @ThrottleUp.started += instance.OnThrottleUp;
                @ThrottleUp.performed += instance.OnThrottleUp;
                @ThrottleUp.canceled += instance.OnThrottleUp;
                @ThrottleDown.started += instance.OnThrottleDown;
                @ThrottleDown.performed += instance.OnThrottleDown;
                @ThrottleDown.canceled += instance.OnThrottleDown;
                @Yaw.started += instance.OnYaw;
                @Yaw.performed += instance.OnYaw;
                @Yaw.canceled += instance.OnYaw;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
                @Aerobrake.started += instance.OnAerobrake;
                @Aerobrake.performed += instance.OnAerobrake;
                @Aerobrake.canceled += instance.OnAerobrake;
                @ChangeCam.started += instance.OnChangeCam;
                @ChangeCam.performed += instance.OnChangeCam;
                @ChangeCam.canceled += instance.OnChangeCam;
                @CameraRotation.started += instance.OnCameraRotation;
                @CameraRotation.performed += instance.OnCameraRotation;
                @CameraRotation.canceled += instance.OnCameraRotation;
                @GearChange.started += instance.OnGearChange;
                @GearChange.performed += instance.OnGearChange;
                @GearChange.canceled += instance.OnGearChange;
                @Throttle.started += instance.OnThrottle;
                @Throttle.performed += instance.OnThrottle;
                @Throttle.canceled += instance.OnThrottle;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnStickInputXY(InputAction.CallbackContext context);
        void OnThrottleUp(InputAction.CallbackContext context);
        void OnThrottleDown(InputAction.CallbackContext context);
        void OnYaw(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnAerobrake(InputAction.CallbackContext context);
        void OnChangeCam(InputAction.CallbackContext context);
        void OnCameraRotation(InputAction.CallbackContext context);
        void OnGearChange(InputAction.CallbackContext context);
        void OnThrottle(InputAction.CallbackContext context);
    }
}
