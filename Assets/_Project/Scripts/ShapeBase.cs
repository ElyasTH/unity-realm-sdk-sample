using System;
using _Project.Scripts.Models;
using Realms;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts
{
    public class ShapeBase : MonoBehaviour
    {
        private Realm _realm;
        private ShapeBaseModel _shapeBaseModel;
        [SerializeField] private int id;
        
        [Header("Appearance")]
        [SerializeField] private ShapeType shapeType;
        [SerializeField] private Color shapeColor;

        [Header("Buttons")]
        [SerializeField] private Button saveButton;
        [SerializeField] private Button loadButton;
    
        private ShapeData _shapeData;
        private SpriteRenderer _spriteRenderer;
    
        private void Awake()
        {
            _shapeData = Resources.Load<ShapeData>("ShapeData");
            _spriteRenderer = GetComponent<SpriteRenderer>();
        
            Load();
        }

        private void OnEnable()
        {
            _realm = Realm.GetInstance();
            _shapeBaseModel = _realm.Find<ShapeBaseModel>(id);
            
            if (_shapeBaseModel == null)
            {
                _realm.Write(() =>
                {
                    _shapeBaseModel = _realm.Add(new ShapeBaseModel(id, transform.position.x, transform.position.y , shapeType.ToString(), shapeColor.ToString()));
                });
            }

            Load();
        }

        private void OnDisable()
        {
            _realm.Dispose();
        }

        public void Save()
        {
            //Todo Save
        }

        public void Load()
        {
            transform.position = new Vector3(_shapeBaseModel.PosX, _shapeBaseModel.PosY, 0);
            
        
            _spriteRenderer.sprite = _shapeData.GetSprite(shapeType);
            _spriteRenderer.color = shapeColor;
        }
    }

    public enum ShapeType
    {
        None,
        Circle,
        Square,
        Triangle
    }
}